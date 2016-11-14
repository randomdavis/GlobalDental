using System;

namespace GlobalDentalUI
{
    class Patient
    {
        public Patient(int PatientID, DateTime Birthdate, string FirstName, string LastName, string Region, string Country)
        {
            this.PatientID = PatientID;
            this.Birthdate = Birthdate;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Region = Region;
            this.Country = Country;
        }

        public int PatientID { get; }
        public DateTime Birthdate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
