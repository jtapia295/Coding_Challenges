using System;
using System.Linq;
using System.Collections;

namespace Coding_Challenges
{
    public class PalindromeChallenge
    {

        //Method to check if int is Palindrome
        public static bool checkNumber(string number)
        {
            char [] numArray = number.ToCharArray();
            Array.Reverse(numArray);
            string reversedNum = new string(numArray);
            bool numIsPalindrome = number == reversedNum;

            return numIsPalindrome;
        }

        //Method to add adjacent pair of numbers
        public static string intDescendent(string parentNumber)
        {
            int[] childNum = new int[parentNumber.Length /2];
            for (int i = 0; i < parentNumber.Length; i += 2)
            {
                try
                {
                   int iSum = Int32.Parse(parentNumber[i].ToString()) + Int32.Parse(parentNumber[i + 1].ToString());
                   childNum.Append(iSum);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Descendent Int Created");
                }
            }
            string childDesc = string.Join("", childNum);

            return childDesc;
        }

        //The Program
        public static void Main(string[] args)
        {
            //Obtain user Input and validate accordingly
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            bool numCheck = userInput.All(char.IsDigit);
            if (numCheck == false)
                Console.WriteLine("Please enter a 6 digit number");
            else if (userInput.Length % 2 == 1 || userInput.Length < 2)
            {
                Console.WriteLine("Please enter a a number with at least two digits that is also even");
            }

            //Check if initial parent int is a palindrome
            bool palinCheck = checkNumber(userInput);
            Console.WriteLine($"You entered {userInput}");
            string currentNum = userInput;
            while (currentNum.Length > 2)
            {
                if (palinCheck)
                {
                    Console.WriteLine($"Your number {currentNum} is a palindrome");
                    currentNum = "h";
                    
                }
                else
                {
                    Console.WriteLine($"Your number {currentNum} is not a palindrome");
                    currentNum = intDescendent(currentNum);
                    palinCheck = checkNumber(currentNum);
                }
  
            }



        }
        public PalindromeChallenge()
        {
        }
    }
}
