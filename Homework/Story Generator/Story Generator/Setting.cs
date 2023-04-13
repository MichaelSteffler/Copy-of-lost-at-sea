///Flynn Lundeen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Story_Generator
{
    class Setting
    {
        //Fields
        static string path = "Setting.txt";

        private string time;
        private string location;

        List<string> times = new List<string>();
        List<string> locations = new List<string>();


        Random r = new Random();

        //Constructor - auto loads in from text file
        public Setting()
        {
            LoadSettings();
        }

        /// <summary>
        /// Loads from the Setting.txt file into two seperate lists of strings. one list holds the times and the other holds the locations 
        /// </summary>
        private void LoadSettings()
        {
            StreamReader reader = File.OpenText("Setting.txt");
            string holder;
            while((holder = reader.ReadLine()) != "locations")
            {
                times.Add(holder);
            }

            while((holder = reader.ReadLine()) != null)
            {
                locations.Add(holder);
            }
        }

        /// <summary>
        /// Sets new time and location for next current story
        /// </summary>
        public void GetNewSetting()
        {
            time = times[r.Next(times.Count)];
            location = locations[r.Next(locations.Count)];
        }

        /// <summary>
        /// Get method for current time
        /// </summary>
        /// <returns>time used for current story</returns>
        public string GetTime()
        {
            return " " + time + " ";
        }
        
        /// <summary>
        /// Get method for current location
        /// </summary>
        /// <returns>location used for current story</returns>
        public string GetLocation()
        {
            return " " + location + " ";
        }

    }
}
