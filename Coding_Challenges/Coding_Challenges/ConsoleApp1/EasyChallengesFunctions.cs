using System;
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
    }
}
