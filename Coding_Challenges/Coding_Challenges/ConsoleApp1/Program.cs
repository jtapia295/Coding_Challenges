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

            //--------------------------------------------------------------------------------------
            //Tests for Generic Binary Tree

            //var root = new Node<int>(10);
            //root.Insert(5);
            //root.Insert(3);
            //root.Insert(12);
            //root.Insert(13);
            //root.Insert(11);
            //root.Insert(6);
            //string treeData = string.Join(", ", root.GetTreeData().Select(d => d.ToString()));

            //Console.WriteLine(treeData);
            //Console.WriteLine("\n\n\n\n");

            //var root2 = new Node<string>("13");
            //root2.Insert("5");
            //root2.Insert("3");
            //root2.Insert("11");
            //root2.Insert("12");
            //root2.Insert("10");
            //root2.Insert("6");
            //string treeData2 = string.Join(", ", root2.GetTreeData().Select(d => d.ToString()));
            //Console.WriteLine(treeData2);

            //---------------------------------------------------------------------------------------------
            //Tests for Multiple Choice Tests Challenge

            var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
            var paper4 = new Testpaper("Physics", new string[] { "1A", "2B", "3A", "4C", "5A", "6C", "7A", "8C", "9D", "10A", "11A" }, "90%");


            //Console.WriteLine(string.Join(",",paper4.MarkScheme.Select(d => d.ToString())));
            
            
            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();

            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            student3.TakeTest(paper1, new string[] { "1C", "2D", "3A", "4C", "5A" });
            student3.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            student3.TakeTest(paper4, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B", "8C", "9D", "10A", "11A" });

            Console.WriteLine(string.Join(",",student3.TestsTaken.Select(d => d.ToString()))); 
        }
      
      
    }
}
