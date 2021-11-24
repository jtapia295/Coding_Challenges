using System;
using System.Linq;
namespace Coding_Challenges.Easy
{
    //Synopsis: Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
    public class MonthNumberConversion
    {
        //Method implemented to convert the numberto Month
        public static string MonthConversion(int n)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            string month = months[n - 1];

            return month;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter a number for the month you would like to Access.");
            bool monthCheck = int.TryParse(Console.ReadLine(),out int monthChoice);
            while (!monthCheck || (monthChoice < 1 || monthChoice > 12))
            {
                Console.WriteLine("Please enter a number between 1-12");
                monthCheck = int.TryParse(Console.ReadLine(), out monthChoice);
            }
            string selectMonth = MonthConversion(monthChoice);

            Console.WriteLine($"You have selected the month {selectMonth}");

        }
        public MonthNumberConversion()
        {
        }
    }
}
