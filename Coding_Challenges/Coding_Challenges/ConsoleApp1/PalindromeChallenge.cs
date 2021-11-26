using System;
namespace Coding_Challenges
{
    public static class PalindromeChallenge
    {


        //Function to check is number or descendants are Palindrome
        public static bool PalindromeDescendent(int num)
        {
            //Convert num to string
            string currentNum = num.ToString();
            
            while (currentNum.Length >= 2)
            {
                //Check if current number is a Palingdrome
                char[] numArray = currentNum.ToCharArray();
                Array.Reverse(numArray);
                bool palinCheck = currentNum == new string(numArray);

                //Ends function if num is a palindrome
                if (palinCheck)
                {
                    return true;
                }
                else if (!palinCheck)
                {
                    if (currentNum.Length == 2)
                    {
                        return false;
                    }

                    string[] childNum = new string[currentNum.Length];

                    for (int i = 0; i < currentNum.Length; i += 2)
                    {
                        try
                        {
                            string iSum = (Int32.Parse(currentNum[i].ToString()) + Int32.Parse(currentNum[i + 1].ToString())).ToString();
                            childNum[i] = iSum;
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("Descendent Int Created");
                        }
                    }
                    currentNum = string.Join("", childNum);
                    currentNum.Trim();
                }
             
            }
            return false;

        }
    }
}
