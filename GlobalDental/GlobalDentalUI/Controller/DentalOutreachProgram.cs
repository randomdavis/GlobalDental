using System;
using System.Collections.Generic;
using GlobalDentalUI.Model;

namespace GlobalDentalUI.Controller
{
    public class DentalOutreachProgram
    {
        public DentalOutreachProgram(string name = "Test DOP")
        {
            Patients = new List<Patient>();
            CurrentPatient = null;
            ProgramName = name;
        }

        public Treatment AddTreatment(int PatientID, Treatment.TreatmentType Type, Treatment.TreatmentSurfaces TreatmentSurfaces, Treatment.TreatmentStatus Status, int toothNumber, bool isUSAToothNumber = true)
        {
            Patient gottenPatient = GetPatient(PatientID);

            if (gottenPatient != null)
            {
                Tooth TreatmentTooth = null;

                if (toothNumber != 0)
                {
                    foreach (Tooth FoundTooth in gottenPatient.Teeth)
                    {
                        if (isUSAToothNumber == true)
                        {
                            if (FoundTooth.Number.USAToothNumber == toothNumber)
                            {
                                TreatmentTooth = FoundTooth;
                                break;
                            }
                        }
                        else
                        {
                            if (FoundTooth.Number.UniversalToothNumber == toothNumber)
                            {
                                TreatmentTooth = FoundTooth;
                                break;
                            }
                        }

                    }
                }

                Treatment newTreatment = new Treatment(Type, TreatmentSurfaces, Status, TreatmentTooth);
                gottenPatient.TreatmentsList.Add(newTreatment);
                return newTreatment;
            }
            else
            {
                throw new Exception("Invalid patient ID " + PatientID.ToString());
            }
        }

        public Patient AddPatient(DateTime BirthDate, string FirstName, string LastName, string Region, string Country, string Notes, Patient.Gender Gender)
        {
            var NewPatient = new Patient(Patients.Count + 1, BirthDate, FirstName, LastName, Region, Country, Gender, Notes);
            Patients.Add(NewPatient);
            return NewPatient;
        }

        public bool UpdatePatient(int ID, DateTime BirthDate, string FirstName, string LastName, string Region, string Country, string Notes, Patient.Gender Gender)
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
                    Patient.PatientNotes = Notes;
                    Patient.PatientGender = Gender;
                    return true;
                }
            }

            return false;
        }

        public void ExistingOtherOnTooth(int patientID, int toothNumber, bool isUSANumber = true)
        {
            Patient patient = GetPatient(patientID);

            int USANumber = toothNumber;

            int[] UniversalToothNumbers = { 18, 17, 16, 15, 14, 13, 12, 11, 28, 27, 26, 25, 24, 23, 22, 21,
                    48, 47, 46, 45, 44, 43, 42, 41, 38, 37, 36, 35, 34, 33, 32, 31 };

            if (isUSANumber == false)
            {
                for (int i = 0; i < 32; i++)
                {
                    if (UniversalToothNumbers[i] == toothNumber)
                    {
                        USANumber = i + 1;
                    }
                }
            }

            foreach (Treatment treatment in patient.TreatmentsList)
            {
                if (treatment.TreatmentTooth != null)
                {
                    if (treatment.Status == Treatment.TreatmentStatus.Planned && treatment.TreatmentTooth.Number.USAToothNumber == toothNumber)
                    {
                        treatment.Status = Treatment.TreatmentStatus.Existing;
                    }
                }
            }
        }

        public void CompleteTreatmentsOnTooth(int patientID, int toothNumber, bool isUSANumber = true)
        {
            Patient patient = GetPatient(patientID);

            int USANumber = toothNumber;

            int[] UniversalToothNumbers = { 18, 17, 16, 15, 14, 13, 12, 11, 28, 27, 26, 25, 24, 23, 22, 21,
                    48, 47, 46, 45, 44, 43, 42, 41, 38, 37, 36, 35, 34, 33, 32, 31 };

            if (isUSANumber == false)
            {
                for (int i = 0; i < 32; i++)
                {
                    if(UniversalToothNumbers[i] == toothNumber)
                    {
                        USANumber = i + 1;
                    }
                }
            }

            foreach (Treatment treatment in patient.TreatmentsList)
            {
                if (treatment.TreatmentTooth != null)
                {
                    if (treatment.Status == Treatment.TreatmentStatus.Planned && treatment.TreatmentTooth.Number.USAToothNumber == toothNumber)
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

        public List<Patient> Patients { get; private set; }
        public Patient CurrentPatient { get; set; }
        public string ProgramName { get; private set; }
    }
}
