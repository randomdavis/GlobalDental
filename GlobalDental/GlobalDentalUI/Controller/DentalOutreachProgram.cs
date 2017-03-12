using System;
using System.Collections.Generic;
using GlobalDentalUI.Model;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace GlobalDentalUI.Controller
{
    public class DentalOutreachProgram
    {
        public DentalOutreachProgram(string name = "Test DOP")
        {
            Patients = new List<Patient>();
            CurrentPatient = null;
            ProgramName = name;
            loggedIn = false;
            sessionToken = null;
        }

        public string getSerializedJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void Serialize(string outFile = "data.json")
        {
            var JSONData = getSerializedJSON();
            File.WriteAllText(outFile, JSONData);
        }

        public DentalOutreachProgram Deserialize(string outFile = "data.json")
        {
            var fileContents = System.IO.File.ReadAllText(outFile);
            return JsonConvert.DeserializeObject<DentalOutreachProgram>(fileContents);
        }

        public string sessionToken { get; set; }
        public bool loggedIn { get; set; }

        public DentalOutreachProgram LogIn(string ClientID)
        {
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                var messageLength = 1024 * 100;
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] helloMessage = encoder.GetBytes("LOGN:" + ClientID);

                stm.Write(helloMessage, 0, helloMessage.Length);

                byte[] payloadBytes = new byte[messageLength];
                int k = stm.Read(payloadBytes, 0, messageLength);
                tcpclnt.Close();

                byte[] truncatedReceiveBuffer = new byte[k];
                Array.Copy(payloadBytes, truncatedReceiveBuffer, k);

                var payload = encoder.GetString(truncatedReceiveBuffer);
                sessionToken = payload.Substring(0, 10);
                loggedIn = true;
                if (payload.Length > 10)
                {
                    return JsonConvert.DeserializeObject<DentalOutreachProgram>(payload.Substring(11));
                }
                else
                {
                    return null;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return null;
            }
        }

        public string Register(string clientID)
        {
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                var messageLength = 1024 * 100;
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] helloMessage = encoder.GetBytes("REGS:" + clientID);

                stm.Write(helloMessage, 0, helloMessage.Length);

                byte[] ReceivedBytes = new byte[messageLength];
                int k = stm.Read(ReceivedBytes, 0, messageLength);
                tcpclnt.Close();

                byte[] truncatedReceiveBuffer = new byte[k];
                Array.Copy(ReceivedBytes, truncatedReceiveBuffer, k);

                var receivedString = encoder.GetString(truncatedReceiveBuffer);
                if (receivedString.Substring(0, 4) != "GOOD")
                {
                    return receivedString;
                }
                else
                {
                    sessionToken = receivedString.Substring(5);
                    loggedIn = true;
                    return "";
                }
            }

            catch (Exception e)
            {
                return e.StackTrace;
            }
        }

        public bool Sync()
        {
            if (!loggedIn)
            {
                return false;
            }
            try
            {
                var serverPort = 5678;
                var serverIP = "127.0.0.1";
                TcpClient tcpclnt = new TcpClient();

                tcpclnt.Connect(serverIP, serverPort);

                Stream stm = tcpclnt.GetStream();
                var encoder = new UTF8Encoding();
                byte[] syncPayload = encoder.GetBytes("SYNC:" + sessionToken + ":" + getSerializedJSON());

                stm.Write(syncPayload, 0, syncPayload.Length);

                tcpclnt.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
                return false;
            }

            
        }

        public Treatment AddTreatment(int PatientID, Treatment.TreatmentType Type, Treatment.TreatmentSurfaces TreatmentSurfaces, Treatment.TreatmentStatus Status, int toothNumber)
        {
            Patient gottenPatient = GetPatient(PatientID);

            if (gottenPatient != null)
            {
                int treatmentID;
                var count = gottenPatient.TreatmentsList.Count;
                if (count == 0)
                {
                    treatmentID = 1;
                }
                else
                {
                    treatmentID = gottenPatient.TreatmentsList[count - 1].ID + 1;
                }
                Treatment newTreatment = new Treatment(treatmentID, Type, TreatmentSurfaces, Status, toothNumber);
                gottenPatient.TreatmentsList.Add(newTreatment);
                return newTreatment;
            }
            else
            {
                throw new Exception("Invalid patient ID " + PatientID.ToString());
            }
        }

        public Patient AddPatient(DateTime BirthDate, string FirstName, string LastName, string Region, string Country, Patient.Gender Gender)
        {
            var NewPatient = new Patient(Patients.Count + 1, BirthDate, FirstName, LastName, Region, Country, Gender);
            Patients.Add(NewPatient);
            return NewPatient;
        }

        public bool UpdatePatient(int ID, DateTime BirthDate, string FirstName, string LastName, string Region, string Country, Patient.Gender Gender)
        {
            foreach (var Patient in Patients)
            {
                if (Patient.PatientID == ID)
                {
                    Patient.Birthdate = BirthDate;
                    Patient.FirstName = FirstName;
                    Patient.LastName = LastName;
                    Patient.Region = Region;
                    Patient.Country = Country;
                    Patient.PatientGender = Gender;
                    return true;
                }
            }

            return false;
        }

        public bool DeleteTreatment(int PatientID, int TreatmentID)
        {
            var PatientToUpdate = GetPatient(PatientID);
            var TreatmentToUpdate = GetTreatment(TreatmentID, PatientID);

            if (TreatmentToUpdate != null && PatientToUpdate != null)
            {
                PatientToUpdate.TreatmentsList.Remove(TreatmentToUpdate);
                return true;
            }

            return false;
        }

        public bool UpdateTreatment(int PatientID, int TreatmentID, Treatment.TreatmentStatus Status, int? ToothNumber)
        {
            var TreatmentToUpdate = GetTreatment(TreatmentID, PatientID);

            if (TreatmentToUpdate != null)
            {
                if (TreatmentToUpdate.Status != Status)
                {
                    TreatmentToUpdate.SetStatus(Status);
                }
                TreatmentToUpdate.ToothNumber = ToothNumber;
                return true;
            }

            return false;
        }

        public void ExistingOtherOnTooth(int patientID, int toothNumber)
        {
            Patient patient = GetPatient(patientID);

            foreach (Treatment treatment in patient.TreatmentsList)
            {
                if (treatment.ToothNumber != null)
                {
                    if (treatment.Status == Treatment.TreatmentStatus.Planned && treatment.ToothNumber == toothNumber)
                    {
                        treatment.Status = Treatment.TreatmentStatus.Existing;
                    }
                }
            }
        }

        public void CompleteTreatmentsOnTooth(int patientID, int toothNumber)
        {
            Patient patient = GetPatient(patientID);

            foreach (Treatment treatment in patient.TreatmentsList)
            {
                if (treatment.ToothNumber != null)
                {
                    if ((treatment.Status == Treatment.TreatmentStatus.Existing || treatment.Status == Treatment.TreatmentStatus.Planned) && treatment.ToothNumber == toothNumber)
                    {
                        treatment.Status = Treatment.TreatmentStatus.Completed;
                    }
                }
            }
        }

        public List<Patient> SearchPatients(string name)
        {
            var FoundPatients = new List<Patient>();

            var lowerCaseName = name.ToLower();

            foreach (var Patient in Patients)
            {
                if (Patient.FirstName.ToLower().Contains(lowerCaseName) || Patient.LastName.ToLower().Contains(lowerCaseName) ||
                    (Patient.FirstName.ToLower() + " " + Patient.LastName.ToLower()).Contains(lowerCaseName))
                {
                    FoundPatients.Add(Patient);
                }
            }

            return FoundPatients;
        }

        public Patient GetPatient(int ID)
        {

            foreach (var Patient in Patients)
            {
                if (Patient.PatientID == ID)
                {
                    return Patient;
                }
            }

            return null;
        }

        public Treatment GetTreatment(int TreatmentID, int PatientID)
        {
            foreach (var Patient in Patients)
            {
                if (Patient.PatientID == PatientID)
                {
                    foreach (var Treatment in Patient.TreatmentsList)
                    {
                        if (Treatment.ID == TreatmentID)
                        {
                            return Treatment;
                        }
                    }
                }
            }

            return null;
        }

        public List<Patient> Patients { get; private set; }
        public Patient CurrentPatient { get; set; }
        public string ProgramName { get; private set; }
    }
}
