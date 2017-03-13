using System;
using System.Collections.Generic;

namespace GlobalDentalUI.Model
{
    public class Patient
    {
        public enum Gender
        {
            Male,
            Female
        }

        public Patient(int PatientID, DateTime Birthdate, string FirstName, string LastName, string Region, string Country, Gender PatientGender)
        {
            this.PatientID = PatientID;
            this.Birthdate = Birthdate;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Region = Region;
            this.Country = Country;
            this.PatientGender = PatientGender;
            CreationDate = DateTime.Now.ToUniversalTime();
            TreatmentsList = new List<Treatment>();
        }

        public int PatientID { get; private set; }
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public Gender PatientGender { get; set; }
        public string TreatmentNotes { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Treatment> TreatmentsList { get; }
    }
}
