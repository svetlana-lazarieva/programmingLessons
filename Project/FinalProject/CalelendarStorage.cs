using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalProject
{
    public class CalelendarStorage
    {
        private readonly string FilePath = $"{Environment.CurrentDirectory}\\Calelendar.json";
        public Year CurrentYear = new Year();

        public void Save()
        {
            string json = JsonConvert.SerializeObject(CurrentYear);

            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.Write(json);
                sw.Close();
            }
        }

        public bool Load()
        {
            if (!File.Exists(FilePath))
            {
                return false;
            }
            string json = string.Empty;
            using (StreamReader sr = new StreamReader(FilePath))
            {
                json = sr.ReadToEnd();
                sr.Close();
            }

            CurrentYear = JsonConvert.DeserializeObject<Year>(json);
            return true;
        }



    }
}
