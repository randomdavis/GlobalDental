using System;

namespace GlobalDentalUI.Model
{
    public class Treatment
    {
        public class Surfaces
        {

            public Surfaces(bool Buccal, bool Distal, bool Lingual, bool Mesial, bool Occlusal)
            {
                this.Buccal = Buccal;
                this.Distal = Distal;
                this.Lingual = Lingual;
                this.Mesial = Mesial;
                this.Occlusal = Occlusal;
            }

            public bool Buccal { get; private set; }
            public bool Distal { get; private set; }
            public bool Lingual { get; private set; }
            public bool Mesial { get; private set; }
            public bool Occlusal { get; private set; }

        }
        public enum TreatmentType
        {
            Amalgam,
            Prophylaxis,
            Fluoride,
            Extraction,
            Composite,
            Sealants
        }

        public enum TreatmentStatus
        {
            Existing,
            Planned,
            Completed
        }

        public class ToothNumber
        {
            private int USAToothNumber;

            public int GlobalToothNumber
            {
                get { return USAToothNumber; }
                set { USAToothNumber = value; }
            }

        }

        public Treatment(TreatmentType Type, ToothNumber TreatmentTooth, Surfaces TreatmentSurfaces, TreatmentStatus Status)
        {
            DateAndTime = DateTime.Now.ToUniversalTime();
            this.Type = Type;
            this.TreatmentTooth = TreatmentTooth;
            if (Type == TreatmentType.Extraction || Type == TreatmentType.Fluoride || Type == TreatmentType.Prophylaxis)
            {
                this.TreatmentSurfaces = new Surfaces(true, true, true, true, true);
            }
            else
            {
                this.TreatmentSurfaces = TreatmentSurfaces;
            }

            if ((Type == TreatmentType.Prophylaxis || Type == TreatmentType.Fluoride) && Status == TreatmentStatus.Existing)
            {
                this.Status = TreatmentStatus.Completed;
            }
            else
            {
                this.Status = Status;
            }
        }
        public DateTime DateAndTime { get; private set; }
        public TreatmentType Type { get; private set; }
        public Surfaces TreatmentSurfaces { get; private set; }
        public TreatmentStatus Status { get; set; }
        public ToothNumber TreatmentTooth { get; private set; }
    }
}
