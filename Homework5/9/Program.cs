using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            for (int i = 0; i < word.Length; ++i)
            {
                Console.WriteLine($"{word[i]} -> {(int)(word[i] - 'a')}");
            }

        }
    }
}
