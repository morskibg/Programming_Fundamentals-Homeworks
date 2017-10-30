using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");
            string tagPattern = @"((?<=<p>).*?(?=<\/p>))";
            var encryptedDataMatchCollection = Regex.Matches(input, tagPattern);
            var encryptedDataList = new List<string>();
            foreach (Match currMatch in encryptedDataMatchCollection)
            {
                encryptedDataList.Add(currMatch.ToString());
            }
            encryptedDataList = encryptedDataList
                .Select(x => Regex.Replace(x, "[^a-z]", " "))                
                .ToList();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < encryptedDataList.Count; ++i)
            {
                for(int j = 0; j < encryptedDataList[i].Length; ++j)
                {

                }
            }
            
            int t = 0;
        }
    }
}
