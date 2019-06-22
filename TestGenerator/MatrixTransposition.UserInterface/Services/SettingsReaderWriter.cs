using MatrixTransposition.UserInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTransposition.UserInterface.Services
{
    public class SettingsReaderWriter
    {
        private const string SETTINGS_FILE = @"settings.json";

        public void WriteSettings(Settings settings)
        {
            File.WriteAllText(SETTINGS_FILE, JsonConvert.SerializeObject(settings));
        }

        public Settings ReadSettings()
        {
            string jsonFileText = null;
            try
            {
                jsonFileText = File.ReadAllText(SETTINGS_FILE);
            }
            catch(Exception ex)
            {
                WriteSettings(new Settings());
                jsonFileText = File.ReadAllText(SETTINGS_FILE);
            }            
            return JsonConvert.DeserializeObject<Settings>(jsonFileText);
        }
    }
}
