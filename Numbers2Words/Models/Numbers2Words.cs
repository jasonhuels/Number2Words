using System;

namespace Numbers2Words
{
    public class NumbersToWords
    {
        public static string Numbers2Words(int number)
        {
            string output = "";
            string[] ones = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] teens = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] tens = {"dummy", "dummy", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", " eighty", "ninety"};
            string[] place = {"dummy", "dummy", "hundred", "thousand", "million", "billion", "trillion"};
            
            if(number > 19)
            {
                char[] nums = number.ToString().ToCharArray();
                int[] numArr = new int[nums.Length];
                for(int i=0; i<nums.Length; i++)
                {
                    numArr[i] = ((int)nums[nums.Length-1-i])-48;
                } 
            }
            
            
            if(number > 9 && number < 20)
            {
                output = teens[number-10];
            }
            else
            {
                output = ones[number];
            }
            return output;
        }
    }
}