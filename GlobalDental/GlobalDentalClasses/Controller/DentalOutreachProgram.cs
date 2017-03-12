using System;
using System.Collections.Generic;
using GlobalDentalClasses.Model;

namespace GlobalDentalClasses.Controller
{
    public class DentalOutreachProgram
    {
        public DentalOutreachProgram(DateTime startDate, DateTime endDate, string region, string country, string name = "Dental Outreach Program")
        {
            Patients = new List<Patient>();
            StartDate = startDate;
            EndDate = endDate;
            Country = country;
            Region = region;
            Name = name;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }

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
    }
}
