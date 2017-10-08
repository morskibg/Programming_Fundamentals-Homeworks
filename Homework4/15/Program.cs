using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int charsToPrintAfterP = int.Parse(Console.ReadLine());

            const char charToSearch = 'p';
            bool isMatched = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == charToSearch)
                {
                    isMatched = true;

                    int endLenth = charsToPrintAfterP + 1;

                    if (endLenth  + i > text.Length)
                    {
                        endLenth = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endLenth);
                    Console.WriteLine(matchedString);
                    i += charsToPrintAfterP;
                }
            }

            if (!isMatched)
            {
                Console.WriteLine("no");
            }
        }
    }
}
