using System;
using System.Linq;
using System.Collections.Generic;
using static Coding_Challenges.EasyChallengesFunction;

namespace Coding_Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> easyChallenges = new List<string> { "Month Converter", "FindMinMaxNum", "MultiplyAllIntbyLengthofArray" };

            //Have user select the challenge they want to view
            Console.WriteLine("Please select the challenge you would like to cover by entering the number");
            int i = 1;
            foreach (string item in easyChallenges)
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }

            bool userSelect = int.TryParse(Console.ReadLine(), out int selectedChallenge);
            selectedChallenge = selectedChallenge - 1;

            if (userSelect && (selectedChallenge <= easyChallenges.Count - 1 && selectedChallenge >= 0))
            {
                switch (selectedChallenge)
                {
                    case 0:
                        Console.WriteLine("Please select a number for the month you would like to access, 1-12");
                        bool numCheck = false;
                        int selectedMonth = -1;
                        numCheck = int.TryParse(Console.ReadLine(), out selectedMonth);
                        while (numCheck == false || (selectedMonth > 12 || selectedMonth < 0))
                        {
                            Console.WriteLine("Please enter a value between 1-12");
                            numCheck = int.TryParse(Console.ReadLine(), out selectedMonth);
                        }
                         Console.WriteLine($"You have accessed the month {MonthConverter(selectedMonth)}");
                        break;
                    
                    case 1:
                        Console.WriteLine("Please enter a list of numbers to parse");
                        string userInput = Console.ReadLine();
                        string[] userArray = userInput.Split("");

                        break;
                }
            }
        }

    }
}
