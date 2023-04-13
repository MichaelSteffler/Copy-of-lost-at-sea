//Flynn Lundeen,Narai Risser, Freddie douglas, and Michael Steffler
//1/14/2021
// We did Problems 1, 2, 3, and 5. These are the group work problems.

using System;

namespace GroupVersionControl
{
    class Program
    {

        // This is a comment that I have added to the file Freddie


        //Quarantine is so much fun - Flynn

        // Michael Steffler

        // The big folder 


        static void Main(string[] args)
        {
            int[] x = { 2, 2, 4, 10, 10, 10, 10, 4, 2, 2, 2, 4 };
            int[] y = { 5, 2, 4, 4, 6, 6, 6, 7, 7, 7, 1, 2 }; 
            DiceSum();
            Console.WriteLine();
            Console.WriteLine( LastFirst("Wedge Antilles"));
            Console.WriteLine();
            Console.WriteLine( IsPalindrome("Tacocat"));
            Console.WriteLine();
            Console.WriteLine(  IsPalindrome("happy birthday"));
            Console.WriteLine();
            Console.WriteLine(  LongestDupe(x));
            Console.WriteLine();
            Console.WriteLine(   LongestDupe(y));
            
        }
        /// <summary>
        /// finds the longest chain of duplicates
        /// </summary>
        /// <param name="input">the array checked</param>
        /// <returns>what number the longest chain was made of</returns>
        static int LongestDupe(int[] input)
        {
            int counter = 1;
            int currentLongest= 0;
            int longestStreak=0;
            for (int i = 1; i < input.Length; i++)
            {
                if(input[i]==input[i-1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if(counter>=longestStreak)
                {
                    longestStreak = counter;
                    currentLongest = input[i];
                }
            }
            return currentLongest;
        }



        /// <summary>
        /// Reorganizes the first and last name so that the last name comes first and adds punctuation
        /// </summary>
        /// <param name="name">First Last</param>
        /// <returns>Last, F.</returns>
        public static string LastFirst(string name)
        {
            string[] holder = name.Split(" ");
            return holder[1] + ", " + holder[0].Substring(0,1) + ".";
        }


        /// <summary>
        /// Reads a word input from the user and then
        /// checks if it is a palindrome
        /// </summary>
        /// <returns></returns>
        public static bool IsPalindrome(string word)
        {
            word = word.ToLower();

            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            { 
                if (word[i] != word[length - i - 1])
                {
                    return false;
                } 
            }
            return true;
            
        }

        /// <summary>
        /// This is used to add random dice to get a number you desire
        /// </summary>
        static void DiceSum()
        {
            Random rand= new Random();
            bool QuitIsFalse = false;
            while(QuitIsFalse == false)
            {
                //askes for dice sum
                Console.WriteLine("Desired dice sum: ");
                int response = int.Parse(Console.ReadLine());
                if(response >= 2 && response <= 12)
                {
                    bool moreThan = false;
                    while(moreThan == false)
                    {
                        //starts rolling dice to find the number you asked for
                        int num1 = rand.Next(1, 7);
                        int num2 = rand.Next(1, 7);
                        int final = num1 + num2;
                        Console.WriteLine(num1 + " and " + num2 + " = " + final);
                        if(final == response)
                        {
                            moreThan = true;
                            QuitIsFalse = true;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid sum");
                    Console.WriteLine("");
                }

            }
            
        }
    }
}
