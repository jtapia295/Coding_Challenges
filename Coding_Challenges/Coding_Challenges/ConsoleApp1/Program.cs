using System;
using System.Linq;
using System.Collections.Generic;
using static Coding_Challenges.ExpertChallenges;



namespace Coding_Challenges
{
    public class Program
    {
        public static void Main(string[] args)
         {
            //    List<string> challenges = new List<string> { "Check if Number is a Palindrome", "Convert time to binary clock", "MultiplyAllIntbyLengthofArray" };

            //    //Have user select the challenge they want to view
            //    Console.WriteLine("Please select the challenge you would like to cover by entering the number");
            //    int i = 1;
            //    foreach (string item in challenges)
            //    {
            //        Console.WriteLine($"{i}.{item}");
            //        i++;
            //    }

            //    bool userSelect = int.TryParse(Console.ReadLine(), out int selectedChallenge);
            //    selectedChallenge = selectedChallenge - 1;

            //    if (userSelect && (selectedChallenge <= challenges.Count - 1 && selectedChallenge >= 0))
            //    {
            //        string userInput;
            //        switch (selectedChallenge)
            //        {
            //            case 0:
            //                //Obtain user Input and validate accordingly
            //                Console.WriteLine("Please enter a number");

            //                userInput = Console.ReadLine();

            //                //Validate that number is a num and it is even
            //                bool numCheck = userInput.All(char.IsDigit);

            //                if (numCheck == false)
            //                    Console.WriteLine("Please enter a 6 digit number");
            //                else if (userInput.Length % 2 == 1 || userInput.Length < 2)
            //                {
            //                    Console.WriteLine("Please enter a a number with at least two digits that is also even");
            //                }

            //                //Check if number contains a palindrome descendent
            //                //Convert input to integer
            //                int userNum = int.Parse(userInput);

            //                //Run the function
            //                bool palinCheck = PalindromeDescendent(userNum);
            //                Console.WriteLine($"You entered {userInput}");

            //                if (palinCheck)
            //                {
            //                    Console.WriteLine("Your number or one of its descendants is a palindrome");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("The number you entered doesnt contain a palindrome");
            //                }
            //                break;

            //            case 1:
            //                Console.WriteLine("Please enter a time in 24 hour format. i.e 12:59:59");
            //                userInput = Console.ReadLine();

            //                string[] binaryClock = BuildBinaryClock(userInput);

            //                Console.WriteLine($"Here is your time in binary format \n " +
            //                    $"{binaryClock[0]}, \n {binaryClock[1]}, \n {binaryClock[2]}, \n {binaryClock[3]}");
            //                break;
                    //}
                //}
         }
      
      
    }
}
