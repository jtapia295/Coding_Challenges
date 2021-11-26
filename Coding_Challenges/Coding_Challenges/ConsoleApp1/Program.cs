using System;
using System.Linq;
using static Coding_Challenges.PalindromeChallenge;

namespace Coding_Challenges
{
    //Objective: Create a function that returns true if the number or any of its descendants are a palindrome.
    public class Program
    {
        public static void Main(string[] args)
        {
            //Obtain user Input and validate accordingly
            Console.WriteLine("Please enter a number");

            string userInput = Console.ReadLine();

            //Validate that number is a num and it is even
            bool numCheck = userInput.All(char.IsDigit);

            if (numCheck == false)
                Console.WriteLine("Please enter a 6 digit number");
            else if (userInput.Length % 2 == 1 || userInput.Length < 2)
            {
                Console.WriteLine("Please enter a a number with at least two digits that is also even");
            }

            //Check if number contains a palindrome descendent
                //Convert input to integer
            int userNum = int.Parse(userInput);

                //Run the function
            bool palinCheck = PalindromeDescendent(userNum);
            Console.WriteLine($"You entered {userInput}");

            if(palinCheck)
            {
                Console.WriteLine("Your number or one of its descendants is a palindrome");
            }
            else
            {
                Console.WriteLine("The number you entered doesnt contain a palindrome");
            }
       
            
        }
      
    }
}
