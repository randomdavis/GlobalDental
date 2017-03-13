using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace GlobalDentalUI.Controller
{
    public class DOPs
    {
        public DOPs(List<DentalOutreachProgram> StartingPrograms = null)
        {
            if(StartingPrograms == null)
            {
                try
                {
                    Programs = Deserialize();
                }
                catch (Exception)
                {
                    Programs = new List<DentalOutreachProgram>();
                }
            }
            else
            {
                Programs = StartingPrograms;
            }
        }

        public string getSerializedJSON()
        {
            return JsonConvert.SerializeObject(Programs);
        }

        public void Serialize(string outFile = "data.json")
        {
            var JSONData = getSerializedJSON();
            File.WriteAllText(outFile, JSONData);
        }

        public List<DentalOutreachProgram> Deserialize(string outFile = "data.json")
        {
            var fileContents = System.IO.File.ReadAllText(outFile);
            return JsonConvert.DeserializeObject<List<DentalOutreachProgram>>(fileContents);
        }

        public List<DentalOutreachProgram> Programs { get; set; }
    }
}
