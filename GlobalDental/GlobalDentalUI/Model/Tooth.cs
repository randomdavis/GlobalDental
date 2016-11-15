using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDentalUI.Model
{
    public class Tooth
    {
        public class ToothSurface
        {
            public ToothSurface()
            {
                Status = null;
            }

            public Treatment.TreatmentStatus? Status { get; set; }
        }

        public class SurfacesList
        {
            public ToothSurface Buccal { get; }
            public ToothSurface Distal { get; }
            public ToothSurface Lingual { get; }
            public ToothSurface Mesial { get; }
            public ToothSurface Occlusal { get; }
        }

        public class ToothNumber
        {
            public int USAToothNumber { get; private set; }

            public ToothNumber(int number, bool USANumber = true)
            {
                if ((0 < number) && (33 > number))
                {
                    if (USANumber == true)
                    {
                        USAToothNumber = number;
                    }
                    else
                    {
                        var found = false;
                        for (int i = 0; i < UniversalToothNumbers.Length; i++)
                        {
                            if (UniversalToothNumbers[i] == number)
                            {
                                USAToothNumber = number + 1;
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            throw new ArgumentOutOfRangeException("number", "The number " + number.ToString() + " is invalid for a Universal tooth number");
                        }
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("number", "The number " + number.ToString() + " is invalid for a USA tooth number");
                }
            }

            public int[] UniversalToothNumbers = { 18, 17, 16, 15, 14, 13, 12, 11, 28, 27, 26, 25, 24, 23, 22, 21,
                    48, 47, 46, 45, 44, 43, 42, 41, 38, 37, 36, 35, 34, 33, 32, 31 };

            public int UniversalToothNumber
            {
                get { return UniversalToothNumbers[USAToothNumber - 1]; }
            }

        }

        public Tooth(int number, bool isUSANumber)
        {
            Number = new ToothNumber(number, isUSANumber);
            Surfaces = new SurfacesList();
        }

        public ToothNumber Number { get; private set; }
        public SurfacesList Surfaces { get; set; }
    }
}
