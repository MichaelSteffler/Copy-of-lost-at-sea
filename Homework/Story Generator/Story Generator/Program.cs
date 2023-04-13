//Freddie douglas
//1/21/2022
//The main where the user will see it's options


using System;
using System.Collections.Generic;

namespace Story_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the story generator!");
            string input = "";
            while (input != "no")
            {
                Console.WriteLine();
                Console.WriteLine("Please choose a type of ending to Generate a story:");
                Console.WriteLine("'happy'        'tragic'         'romantic'");
                Console.WriteLine("'destructive'   'twist'         'random'  ");

                Console.WriteLine("Your Choice = ");
                input = Console.ReadLine().Trim().ToLower();
                //actor - use generateList() before each story to reset and pick to set what both actors names, prof, and descrips are. 1 is the first and 2 is the second person
                //setting - GetNewSetting() before each sotry to set new setting. GetTime() to get time and GetLocation() to get current locaiton
                switch (input)
                {
                    case ("happy"):
                        Story(EndingType.happy);
                        break;
                    case ("tragic"):
                        Story(EndingType.tragic);
                        break;
                    case ("romantic"):
                        Story(EndingType.romantic);
                        break;
                    case ("destructive"):
                        Story(EndingType.destructive);
                        break;
                    case ("twist"):
                        Story(EndingType.twist);
                        break;
                    case ("random"):
                        Story(EndingType.rand);
                        break;
                    default:
                        Console.WriteLine("not a valid input");
                        break;

                        

                }
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Would you like another story? Choose yes or no. >>");
                    input = Console.ReadLine().Trim().ToLower();
                    switch (input)
                    {
                        case ("yes"):
                            break;
                        case ("no"):
                            break;
                        default:
                            Console.WriteLine("not a valid input");
                            break;

                    }
                }
                while (!(input == "yes" || input == "no"));


            }
        }


        public static void Story(EndingType topic)
        {
            Actor people = new Actor();
            Setting place = new Setting();
            Conflict plot = new Conflict(topic);

            people.GenerateList();
            people.Pick();

            place.GetNewSetting();
            
            

            List<string> ListStory = plot.ListStory;

            for (int i = 0; i < ListStory.Count; i++)
            {
                if (plot.IsKey(ListStory[i]))
                {
                    switch (ListStory[i])
                    {
                        // Any of the following keys return true 
                        case "@1": // Name 1
                            Console.Write(people.Name1);
                            break;
                        case "@2": // Name 2
                            Console.Write(people.Name2);
                            break;
                        case "#1": // Profession 1
                            Console.Write(people.Prof1);
                            break;
                        case "#2": // Profession 2
                            Console.Write(people.Prof2);
                            break;
                        case "$1": // Appearance 1
                            Console.Write(people.Descrip1);
                            break;
                        case "$2": // Appearance 2
                            Console.Write(people.Descrip2);
                            break;
                        case "%": // Time
                            Console.Write(place.GetTime());
                            break;
                        case "^": // Location
                            Console.Write(place.GetLocation());
                            break;
                    }
                }
                else
                {
                    Console.Write(ListStory[i]);
                }
            
            }


        }
    }
}
