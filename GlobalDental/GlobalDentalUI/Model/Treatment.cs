using System;
using System.Collections.Generic;

namespace GlobalDentalUI.Model
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
                treatmentCode += TreatmentTooth.Number.USAToothNumber;
            }

            return treatmentCode;
        }

        public void updateSurfaces()
        {
            if(this.TreatmentTooth != null)
            {
                var isWholeTooth = Surfaces.WholeTooth();

                if (Surfaces.Buccal == true || isWholeTooth == true)
                {
                    TreatmentTooth.Surfaces.Buccal.Status = Status;
                }
                if (Surfaces.Distal == true || isWholeTooth == true)
                {
                    TreatmentTooth.Surfaces.Distal.Status = Status;
                }
                if (Surfaces.Lingual == true || isWholeTooth == true)
                {
                    TreatmentTooth.Surfaces.Lingual.Status = Status;
                }
                if (Surfaces.Mesial == true || isWholeTooth == true)
                {
                    TreatmentTooth.Surfaces.Mesial.Status = Status;
                }
                if (Surfaces.Occlusal == true || isWholeTooth == true)
                {
                    TreatmentTooth.Surfaces.Occlusal.Status = Status;
                }
            }
            
        }

        public Treatment(TreatmentType Type, TreatmentSurfaces TreatmentSurfaces, TreatmentStatus Status, Tooth TreatmentTooth = null)
        {
            DateAndTime = DateTime.Now.ToUniversalTime();
            this.Type = Type;

            if (Type == TreatmentType.Prophylaxis || Type == TreatmentType.Fluoride)
            {
                this.TreatmentTooth = null;
                this.Status = Status;
            }
            else
            {  
                this.TreatmentTooth = TreatmentTooth;

                if (Type == TreatmentType.Extraction)
                {
                    Surfaces = new TreatmentSurfaces(WholeTooth: true);
                    this.Status = Status;
                }
                else
                {
                    Surfaces = TreatmentSurfaces;

                    if ((Type == TreatmentType.Prophylaxis || Type == TreatmentType.Fluoride) && Status == TreatmentStatus.Existing)
                    {
                        this.Status = TreatmentStatus.Completed;
                    }
                    else
                    {
                        this.Status = Status;
                    }
                }
                if(this.TreatmentTooth != null)
                {
                    updateSurfaces();
                }
                
                
            }
        }

        public void SetStatus(TreatmentStatus StatusToSet)
        {
            Status = StatusToSet;
        }

        public DateTime DateAndTime { get; private set; }
        public TreatmentType Type { get; private set; }
        public TreatmentSurfaces Surfaces { get; private set; }
        public TreatmentStatus Status { get; set; }
        public Tooth TreatmentTooth { get; private set; }
    }
}
