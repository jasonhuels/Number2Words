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
            string[] tens = {"", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", " eighty", "ninety"};
            string[] place = {"", "", "hundred", "thousand", "million", "billion", "trillion"};

            if(number > 19)
            {
                char[] nums = number.ToString().ToCharArray();
                int[] numArr = new int[nums.Length];
                for(int i=0; i<nums.Length; i++)
                {
                    numArr[i] = ((int)nums[nums.Length-1-i])-ud;
                } 
                
                // for(int i=numArr.Length; i>0; i--)
                // {

                //     if(number > Math.Pow(10, i)-1)
                //     {
                //         if(i == 1) 
                //         {
                //             output += tens[numArr[i]] + " ";
                //             number -= numArr[i] * (int)Math.Pow(10, i); 
                //         }
                //         else
                //         {
                //             output += ones[numArr[i]] + " " + place[2] + " ";
                //             if(i == 5) output += place[2] + " ";
                //             number -= numArr[i] * (int)Math.Pow(10, i);
                //         }
                        
                //     }
                // }
                if(number > 99999) // 100,000 - 999,999 
                {
                    output += ones[numArr[5]] + " " + place[2] + " ";
                    number -= numArr[5] * (int)Math.Pow(10, 5);
                }
                if(number > 19999)  // 20,000 - 99,999 
                {
                    output += tens[numArr[4]] + " ";
                    number -= numArr[4] * (int)Math.Pow(10, 4);
                }
                if (number > 9999)   // 10,000 - 19,999 
                {
                    output += teens[numArr[3]] + " " + place[3] + " ";
                    number -= numArr[3] * (int)Math.Pow(10, 3) + numArr[4] * (int)Math.Pow(10, 4);
                }
                if (number > 999)   // 1,000 - 9,999 
                {
                    output += ones[numArr[3]] + " " + place[3] + " ";
                    number -= numArr[3] * (int)Math.Pow(10, 3);
                }

                if(number > 99)   // 100 - 999 
                {
                    output += ones[numArr[2]] + " " + place[2] + " ";
                    number -= numArr[2] * (int)Math.Pow(10, 2);
                }
                  // 20 - 99 
                output += tens[numArr[1]] + " ";
                number -= numArr[1] * (int)Math.Pow(10, 1); 

            }
            
            if(number > 9 && number < 20)   // 10-19
            {
                output = teens[number-10];
            }
            else   // 0 - 9 
            {
                Console.WriteLine(number);
                output += ones[number];
            }
            return output;
        }
    }
}