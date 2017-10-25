using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static string ReverseCharsInString(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
        static string AddBigNums(string firstNumOrig, string secondNumOrig)
        {
            string firstNum = ReverseCharsInString(firstNumOrig);
            string secondNum = ReverseCharsInString(secondNumOrig);
            int carry = 0;
            List<string> addedNums = new List<string>();
            
            for (int i = 0; i < firstNum.Length; i++)
            {
                int a = (int)char.GetNumericValue(firstNum[i]);
                int b = 0;
                if (i < secondNum.Length)
                {
                    b = (int) char.GetNumericValue(secondNum[i]);
                }
                int c = a + b + carry;
                if (c > 9)
                {
                    addedNums.Add((c % 10).ToString());
                    //carry = c / 10;
                    carry = 1;
                }
                else
                {
                    addedNums.Add(c.ToString());
                    carry = 0;
                }
            }
            if (carry > 0)
            {
                addedNums.Add(carry.ToString());
            }
            addedNums.Reverse();

            string answer = string.Join("", addedNums).TrimStart('0');
            
            return answer;
        }
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            if(firstNum.Length >= secondNum.Length)
            {
                Console.WriteLine(AddBigNums(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine(AddBigNums(secondNum, firstNum));
            }
        }
    }
}
