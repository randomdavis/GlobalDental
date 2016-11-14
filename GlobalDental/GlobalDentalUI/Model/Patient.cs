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


        public Patient(int PatientID, DateTime Birthdate, string FirstName, string LastName, string Region, string Country, Gender PatientGender, string PatientNotes)
        {
            this.PatientID = PatientID;
            this.Birthdate = Birthdate;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Region = Region;
            this.Country = Country;
            this.PatientGender = PatientGender;
            this.PatientNotes = PatientNotes;
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
        public string PatientNotes { get; set; }
        public DateTime CreationDate { get; private set; }
        public List<Treatment> TreatmentsList { get; }
    }
}
