using System;
using System.Linq;
using System.Collections.Generic;
namespace Coding_Challenges
{
    public class EasyChallengesFunction
    {


        //Objective: Create a method that takes in a int and returns the name of the Month corresponding to its numerical value
        public static string MonthConverter(int num)
        {
            string[] allMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int indexedNum = num - 1;
            string selectedMonth = allMonths[indexedNum];
            return selectedMonth;
        }

        //Objective: Create a function that takes in an Int Array and return the minimum and maximum number in the array
        public static string FindMinMax(int[] numArray)
        {
            int max = numArray[0];
            int min = numArray[0];
            for (int i = 0; i <numArray.Length; i++)
            {
                if(min >= numArray[i] && i != numArray.Length)
                {
                    min = numArray[i];
                }
                else if (max < numArray[i] && i != numArray.Length)
                {
                    max = numArray[i];
                }
            }
    
            string minMax = $"{min},{max}";
            return minMax;
        }
    }
}
