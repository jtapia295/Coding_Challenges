using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    //Objective: Write a program that allows you to create a multiple choice test in a class. 
    //Class should be named testpaper implmement an interface called testpaper and contain the subject, Pass Mark, and marking scheme.

    public interface ITestpaper
    {
        string Subject { get; set; }
        string[] MarkScheme { get; set; }
        string PassMark { get; set; }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; set; }
        void TakeTest(ITestpaper paper, string[] anwers);
    }


    public class Testpaper : ITestpaper
    {
        public Testpaper(string subject, string[] scheme, string passMark)
        {
            Subject = subject;
            MarkScheme = scheme;
            PassMark = passMark;
        }

        public string Subject { get; set; }
        public string PassMark { get; set; }
        public string[] MarkScheme { get; set; }
    }

    public class Student : IStudent
    {
        public string[] TestsTaken { get; set; } = { "No tests taken" };
        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int scorer = 0;
            for (int i = 0; i < paper.MarkScheme.Length; i++)
            {
                if (paper.MarkScheme.Contains(answers[i]))
                {
                    scorer++;
                }
            }
            decimal finalScore = decimal.Divide(scorer , paper.MarkScheme.Length) * 100;
            finalScore = Math.Round(finalScore, 0, MidpointRounding.AwayFromZero);
            string passingGrade = paper.PassMark.TrimEnd('%');
            string testResult;
            if ((int)finalScore >= int.Parse(passingGrade))
            {
                testResult = "Passed!";
            }
            else
            {
                testResult = "Failed!";
            }
            List <string>TempList = TestsTaken.ToList();
            TempList.Remove("No tests taken");
            TempList.Add($"{paper.Subject}: {testResult} ({finalScore}%)");
            TempList.Sort();
            TestsTaken = TempList.ToArray();
        }
    }
    internal class MultipleChoiceTests
    {
    }
}
