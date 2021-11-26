using System;
using System.Linq;
using System.Collections.Generic;
using static Coding_Challenges.EasyChallengesFunctions;

namespace Coding_Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> easyChallenges = new List<string> { "Month Converter", "FindMinMaxNum", "MultiplyAllIntbyLengthofArray" };

            //Have user select the challenge they want to view
            Console.WriteLine("Please select the challenge you would like to cover by entering the number");

            foreach (string item in easyChallenges)
            {
                int i = 1;
                Console.WriteLine($"{i}.{item}");
                i++;
            }

            bool userSelect = int.TryParse(Console.ReadLine(), out int selectedChallenge);
            selectedChallenge = selectedChallenge - 1;

            if (userSelect && (selectedChallenge <= easyChallenges.Count - 1 && selectedChallenge > 0))
            {
                switch (easyChallenges)
                {
                    case easyChallenges[0]
                    default:
                }
            }

            //Obtain user Input and validate accordingly
            Console.WriteLine("Please enter a number");

            string userInput = Console.ReadLine();




        }

    }
}
