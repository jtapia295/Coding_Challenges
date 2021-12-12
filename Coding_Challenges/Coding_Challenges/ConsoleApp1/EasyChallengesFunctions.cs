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
            string selectedMonth = allMonths[num - 1];
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

        //Objective: Create a function that multiplies each integer the amount of integers entered.
        public static string MultiplyAllbyLength(int[] numArray)
        {
            string newNumArray = null;
            foreach(int num in numArray)
            {
                if (newNumArray == null)
                {
                    newNumArray = $"{num * numArray.Length}";
                }
                newNumArray = newNumArray + $",{num * numArray.Length}";
            }
            return newNumArray;
        }


        //Objective: Create  a function that takes in an Int[] and returns the absolute sum of arrays. 

    public static int GetAbsSum(int[] arr)
    {
            //int absSum = 0;
            //arr = arr.Select(d => Math.Abs(d)).ToArray();
            //foreach (int num in arr) { absSum += num; }
            //return absSum;

            return arr.Select(Math.Abs).Sum();
            //Alt. Solution
            //return arr.sum(n => Math.Abs(n));
    }

    //Objective: Create a function that takes in an Int and an exponent number and return the calculation
    public static long CalculateExponent(long number, long exponent)
        {
            return (long)Math.Pow(number, exponent);
        }

    //Objective: Create a function that takes in two strings and determines the hamming difference
    public static int HammingDistance(string str1, string str2)
    {
        return str2.Where((ch, i) => ch != str1[i]).Count(); 
    }

     //Objective: Create a function that takes a string name of a person and returns a string with the first and last name swapped.
     public static string nameShuffle(string str)
        {
            return string.Join(" ", str.Substring(str.LastIndexOf(' ') +1), str.Substring(0, str.LastIndexOf(' ')));
            //Alt. Solution
            //return string.Join(" ", str.Split(' ').Reverse());
        }

        //Objective: Create a function that returns the s,aller number
        public static string smallerNum(string n1, string n2)
        {
            if (n1.Select((n, i) => n2[i].GetType() == typeof(char) ? n.CompareTo(n2[i]) : -1).Sum() < 0) { return n1; } else { return n2; }
        }
        
    }
}
