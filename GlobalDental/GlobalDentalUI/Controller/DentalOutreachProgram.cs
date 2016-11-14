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
