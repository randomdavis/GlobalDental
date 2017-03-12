using System;
using System.Collections.Generic;

namespace GlobalDentalClasses.Model
{
    public class Treatment
    {
        public class TreatmentSurfaces
        {

            public TreatmentSurfaces(bool WholeTooth, bool Buccal = false, bool Distal = false, bool Lingual = false, bool Mesial = false, bool Occlusal = false)
            {
                if (WholeTooth == false)
                {
                    this.Buccal = Buccal;
                    this.Distal = Distal;
                    this.Lingual = Lingual;
                    this.Mesial = Mesial;
                    this.Occlusal = Occlusal;
                }
                else
                {
                    this.Buccal = true;
                    this.Distal = true;
                    this.Lingual = true;
                    this.Mesial = true;
                    this.Occlusal = true;
                }
            }

            public bool WholeTooth()
            {
                return Buccal == true && Distal == true && Lingual ==  true && Mesial == true && Occlusal == true;
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

        public string SurfacesString()
        {
            string returnString = "undefined";
            List<string> surfaceNames = new List<string>();

            var isWholeTooth = Surfaces.WholeTooth();

            if (Surfaces.Buccal == true || isWholeTooth == true)
            {
                surfaceNames.Add("Buccal");
            }
            if (Surfaces.Distal == true || isWholeTooth == true)
            {
                surfaceNames.Add("Distal");
            }
            if (Surfaces.Lingual == true || isWholeTooth == true)
            {
                surfaceNames.Add("Lingual");
            }
            if (Surfaces.Mesial == true || isWholeTooth == true)
            {
                surfaceNames.Add("Mesial");
            }
            if (Surfaces.Occlusal == true || isWholeTooth == true)
            {
                surfaceNames.Add("Occlusal");
            }

            if (surfaceNames.Count == 0)
            {
                returnString = "N/A";
            }
            else
            {
                returnString = string.Join(", ", surfaceNames);
            }

            return returnString;
        }

        public string Code(bool specifictooth = true)
        {
            string treatmentCode = "";

            switch (Type)
            {
                case TreatmentType.Amalgam:
                    treatmentCode = "AM";
                    break;
                case TreatmentType.Prophylaxis:
                    treatmentCode = "PRO";
                    break;
                case TreatmentType.Fluoride:
                    treatmentCode = "FL";
                    break;
                case TreatmentType.Extraction:
                    treatmentCode = "EXO";
                    break;
                case TreatmentType.Composite:
                    treatmentCode = "CMP";
                    break;
                case TreatmentType.Sealants:
                    treatmentCode = "SL";
                    break;
                default:
                    treatmentCode = "ERR";
                    break;
            }

            if(specifictooth == true)
            {
                treatmentCode += ToothNumber;
            }

            return treatmentCode;
        }

        public Treatment(int id, TreatmentType Type, TreatmentSurfaces TreatmentSurfaces, TreatmentStatus Status, int? toothNumber = null)
        {
            this.ID = id;
            DateAndTime = DateTime.Now.ToUniversalTime();
            this.Type = Type;

            if (Type == TreatmentType.Prophylaxis || Type == TreatmentType.Fluoride)
            {
                ToothNumber = null;
                this.Status = Status;
            }
            else
            {  
                ToothNumber = toothNumber;

                if (Type == TreatmentType.Extraction)
                {
                    Surfaces = new TreatmentSurfaces(WholeTooth: true);
                    this.Status = Status;
                }
                else
                {
                    if (TreatmentSurfaces != null)
                    {
                        Surfaces = TreatmentSurfaces;
                    }
                    else
                    {
                        Surfaces = new TreatmentSurfaces(WholeTooth: false);
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
            }
        }

        public void SetStatus(TreatmentStatus StatusToSet)
        {
            Status = StatusToSet;
        }

        public DateTime DateAndTime { get; set; }
        public TreatmentType Type { get; private set; }
        public TreatmentSurfaces Surfaces { get; set; }
        public TreatmentStatus Status { get; set; }
        public int? ToothNumber { get; set; }
        public int ID { get; private set; }
    }
}
