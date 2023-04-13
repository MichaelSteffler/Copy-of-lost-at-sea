using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Author Michael Steffler
//Date 1/21/22
namespace Story_Generator
{
    class Actor
    {
        private string name1;
        private string prof1;
        private string descrip1;
        private string name2;
        private string prof2;
        private string descrip2;
        private StreamReader input;
        List<String> list;
        Random rng;
       
        public Actor()
        {
            name1 = "";
            prof1 = "";
            descrip1 = "";
            name2 = "";
            prof2 = "";
            descrip2 = "";
            input = new StreamReader("actor.txt");
            list = new List<string>();
            rng = new Random();
        }

        public string Name1 { get { return " " + name1 + " "; } }
        public string Name2 { get { return " " + name2 + " "; } }
        public string Prof1 { get { return " " + prof1 + " "; } }
        public string Prof2 { get { return " " + prof2 + " "; } }
        public string Descrip1 { get { return " " + descrip1 + " "; } }
        public string Descrip2 { get { return " "+descrip2 + " "; } }










        /// <summary>
        /// clears list and rereads file
        /// </summary>
        public void GenerateList()
        {
            string line = null;
            list.Clear();

            while((line=input.ReadLine()) != null)
            {
                list.Add(line);
            }
        }
        /// <summary>
        /// fills variables for both actors
        /// </summary>
        public void Pick()
        {
            ChooseActor1();
            ChooseActor2();
        }
        /// <summary>
        /// fills variables for first actor
        /// </summary>
        public void ChooseActor1()
        {
            int choice = rng.Next(1, list.Count);
            string[] info = list[choice].Split(",");
            list.RemoveAt(choice);
            name1 = info[0];
            prof1 = info[1];
            descrip1 = info[2];
        }

        /// <summary>
        /// fills variables for first actor
        /// </summary>
        public void ChooseActor2()
        {
            int choice = rng.Next(1, list.Count );
            string[] info = list[choice].Split(",");
            name2 = info[0];
            prof2 = info[1];
            descrip2 = info[2];
        }
        





    }
}
