// ++++++
// Title: Conflict 
// Author: Narai
// Date: 1/21/22
// Description: Gets one of the premade madlib stories based on
//              the story type and splits the story into a list
//              where each item on the list is either a special
//              char or filler text 
// ++++++

// todo: Multiple keys lie @1 and @2 etc 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Story_Generator
{
    public enum EndingType { happy, tragic, romantic, destructive, twist, rand}

    class Conflict
    {
        private string file = "Conflicts.txt";
        private List<string> storyMadlib = new List<string>();

        private List<String> listStory;

        public List<String> ListStory { get { return listStory; } }
        
        /// <summary>
        /// Creates processed story based on the story type 
        /// </summary>
        /// <param name="type"></param>
        public Conflict(EndingType type)
        {
            // Read from the text file 
            StreamReader reader = new StreamReader(file);


            switch(type)
            {
                // In text file every two lines is a story madlib type 
                // There are 2 stories for each 
                case EndingType.happy:
                    ReadFile(0 * 2, reader);
                    break;
                case EndingType.tragic:
                    ReadFile(1 * 2, reader);
                    break;
                case EndingType.romantic:
                    ReadFile(2 * 2, reader);
                    break;
                case EndingType.destructive:
                    ReadFile(3 * 2, reader);
                    break;
                case EndingType.twist:
                    ReadFile(4 * 2, reader);
                    break;
                case EndingType.rand:
                    
                    // Gets all the stories 

                    ReadlAll(reader);
                    break;
            }

            reader.Close();

            Random rand = new Random();

            // Chooses one of the random stories 
            string story = storyMadlib[rand.Next(0, 2)];
            listStory = ProcessStory(story);
        }

        /// <summary>
        /// Reads the conflict file and adds the necessary story to the story madlib 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="reader"></param>
        private void ReadFile(int start, StreamReader reader)
        {
            // Reads up till at necessary lines
            for (int i = 0; i < start; i++)
            {
                reader.ReadLine();
            }

            // Two madlib choices to choose from added 
            storyMadlib.Add(reader.ReadLine());
            storyMadlib.Add(reader.ReadLine());
        }

        /// <summary>
        /// Reads through every line on the file and
        /// adds it to the list 
        /// </summary>
        /// <param name="reader"></param>
        private void ReadlAll(StreamReader reader)
        {
            string current;
            while((current = reader.ReadLine()) != null)
            {
                storyMadlib.Add(reader.ReadLine());
            }
        }

        /// <summary>
        /// Changes the string so that it is a 
        /// list making it easier to work with 
        /// </summary>
        /// <param name="story"></param>
        /// <returns></returns>
        private List<String> ProcessStory(string story)
        {
            List<String> processedStory = new List<string>();
            string[] cutStory = story.Split(" ");

            // Initializes the list 
            processedStory.Add(""); 

            foreach(string word in cutStory)
            {
                if(IsKey(word))
                {
                    processedStory.Add(word);
                    processedStory.Add(""); // Sets up next filler 
                }
                else
                {
                    // Adds filler line word to current item string 

                    // If not the start of a filler line 
                    if (!(processedStory[processedStory.Count - 1] == ""))
                    {
                        // Only needs a space if there is a word before it and "" is the 
                        // default empty string to check for this situation s

                        processedStory[processedStory.Count - 1] += " ";
                    }

                    processedStory[processedStory.Count - 1] += word;

                }
            }

            return processedStory;

        }

        /// <summary>
        /// Checks if the current word is a key 
        /// or not. 
        /// 
        /// Name - @ x 2
        /// Profession - # x 2
        /// Appearance - $ x 2
        /// Time - %
        /// Locatoin - ^
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool IsKey(string word)
        {
            bool isKey = false;
            switch(word)
            {
                // Any of the following keys return true 
                case "@1": // Name 1
                case "@2": // Name 2
                case "#1": // Profession 1
                case "#2": // Profession 2
                case "$1": // Appearance 1
                case "$2": // Appearance 2
                case "%": // Time
                case "^": // Location 
                    isKey = true;
                    break;
            }

            return isKey;
        }
    }
}
