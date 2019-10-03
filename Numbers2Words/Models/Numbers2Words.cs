using System;

namespace Numbers2Words
{
    public class NumbersToWords
    {
        public static string Numbers2Words(int number)
        {
            string output = "";
            int ud = 48; // unicode value for 0, used to change unicode value into integer
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
                    numArr[i] = ((int)nums[nums.Length-1-i])-ud;
                } 
                if(number >= 999999)
                {
                    output += ones[numArr[5]] + " " + place[2] + " ";
                    number -= numArr[5] * (int)Math.Pow(10, 5);
                }
                if(number > 19999)
                {
                    output += tens[numArr[4]] + " ";
                    number -= numArr[4] * (int)Math.Pow(10, 4);
                }
                if (number > 9999) 
                {
                    output += teens[numArr[3]] + " " + place[3] + " ";
                    number -= numArr[3] * (int)Math.Pow(10, 3) + numArr[4] * (int)Math.Pow(10, 4);
                }
                if (number > 999)
                {
                    output += ones[numArr[3]] + " " + place[3] + " ";
                    number -= numArr[3] * (int)Math.Pow(10, 3);
                }

                if(number > 99)
                {
                    output += ones[numArr[2]] + " " + place[2] + " ";
                    number -= numArr[2] * (int)Math.Pow(10, 2);
                }
                output += tens[numArr[1]] + " ";
                number -= numArr[1] * (int)Math.Pow(10, 1); 

            }
            
            if(number > 9 && number < 20)
            {
                output = teens[number-10];
            }
            else
            {
                Console.WriteLine(number);
                output += ones[number];
            }
            return output;
        }
    }
}