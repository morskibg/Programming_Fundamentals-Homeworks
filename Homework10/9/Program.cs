using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool MelrahShake(ref StringBuilder text, ref StringBuilder pattern)
        {
            string tempText = text.ToString();
            string tempPattern = pattern.ToString();
            if (!tempText.Contains(tempPattern))
            {
                return false;
            }
            int beginIdx = tempText.IndexOf(tempPattern);
            int endIdx = tempText.LastIndexOf(tempPattern);
            
            if (endIdx - beginIdx < pattern.Length)
            {
                return false;
            }

            text.Remove(beginIdx, pattern.Length);
            endIdx -= pattern.Length; 
            text.Remove(endIdx, pattern.Length);
           
            return true;
        }
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            StringBuilder pattern = new StringBuilder(Console.ReadLine());
            if (text.Length == 0)
            {
                Console.WriteLine("No shake.");
                return;
            }
            bool isStillRunning = true;
            while (isStillRunning)
            {
                isStillRunning =  MelrahShake(ref text, ref pattern);
                if (isStillRunning)
                {
                    Console.WriteLine("Shaked it.");
                    pattern.Remove(pattern.Length / 2, 1);
                    if (pattern.Length == 0)
                    {
                        isStillRunning = false;
                    }
                }
                if(!isStillRunning)
                {
                    Console.WriteLine("No shake.");
                }
                
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
