﻿using System;
namespace Coding_Challenges
{
    public static class ExpertChallenges
    {


        //Objective: Create a function that takes in a Int and returns a bool value indicating if the number itself or any of its descendents are a palindrome.
        public static bool PalindromeDescendent(int num)
        {
            //Convert num to string
            string currentNum = $"{num}";

            while (currentNum.Length >= 2)
            {
                //Check if current number is a Palindrome
                string reversedNum = "";
                for (int i = currentNum.Length -1 ; i >= 0; i--) 
                {
                    reversedNum = reversedNum + $"{currentNum[i]}";
                }
                Console.WriteLine(reversedNum);
                bool palinCheck = currentNum == reversedNum;

                //Ends function if num is a palindrome
                if (palinCheck)
                {
                    return true;
                }

                else if (!palinCheck)
                {
                    //Ends function if not palindrome and equal length of 2
                    if (currentNum.Length == 2)
                    {
                        return false;
                    }

                    string[] childNum = new string[currentNum.Length];

                    if (currentNum.Length % 2 == 0)
                    {
                        for (int i = 0; i < currentNum.Length - 1; i += 2)
                        {

                            string iSum = (int.Parse(currentNum[i].ToString()) + int.Parse(currentNum[i + 1].ToString())).ToString();
                            childNum[i] = iSum;
                        }
                    }
                    currentNum = string.Join("", childNum);

                    currentNum.Trim();
                    Console.WriteLine(currentNum);
                }
            }
            return false;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        //Objective: Given the time as a string return an array containing strings that shows the lights for each row of the clock. String Format Sample "12:59:59"
        public static string[] BuildBinaryClock(string time)
        {
            //Split string into substrings using the preformatted delimiter
            time = time.Replace(":", "");
            
            //Declare and initialize the string array to return
            string[] binaryTime =
            {
            /*8*/    " 0 0 0",
            /*4*/  " 00000",
            /*2*/ "000000",
            /*1*/ "000000"
            };

            //Iterate through each int in the time entered.
            for (int i = 0; i < time.Length; i++)
            {
                //Convert char in string time to int
                int timeNum = time[i] - '0';

                //Declare a char array of the string index in binaryTime array
                char[] binaryTimeIndex;

                //Use switch statement to manipulate string to correct time
                switch(timeNum)
                {
                    case 1:
                        binaryTimeIndex = binaryTime[3].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[3]  = string.Concat(binaryTimeIndex);
                        break;
                    case 2:
                        binaryTimeIndex = binaryTime[2].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[2] = string.Concat(binaryTimeIndex);
                        break;
                    case 3:
                        binaryTimeIndex = binaryTime[2].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[2] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[3].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[3] = string.Concat(binaryTimeIndex);
                        break;
                    case 4:
                        binaryTimeIndex = binaryTime[1].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[1] = string.Concat(binaryTimeIndex);
                        break;
                    case 5:
                        binaryTimeIndex = binaryTime[3].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[3] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[1].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[1] = string.Concat(binaryTimeIndex);
                        break;
                    case 6:
                        binaryTimeIndex = binaryTime[1].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[1] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[2].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[2] = string.Concat(binaryTimeIndex);
                        break;
                    case 7:
                        binaryTimeIndex = binaryTime[1].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[1] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[2].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[2] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[3].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[3] = string.Concat(binaryTimeIndex);
                        break;
                    case 8:
                        binaryTimeIndex = binaryTime[0].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[0] = string.Concat(binaryTimeIndex);
                        break;
                    case 9:
                        binaryTimeIndex = binaryTime[0].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[0] = string.Concat(binaryTimeIndex);

                        binaryTimeIndex = binaryTime[3].ToCharArray();
                        binaryTimeIndex[i] = '1';
                        binaryTime[3] = string.Concat(binaryTimeIndex);
                        break;
                }
            }
            return binaryTime;
        }
    }
}
