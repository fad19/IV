using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopressedString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Program.compressBad("aabccccaa"));
            Console.WriteLine(Program.compressGood("aabccccaa"));
            Console.ReadLine();
        }
        static string compressGood(string str)
        {
            StringBuilder compressedString = new StringBuilder();
            int consecutiveCount = 0;
            char[] charStringArray = str.ToCharArray();

            for (int i = 0; i < charStringArray.Length; i++)
            {
                consecutiveCount++;

                if (i + 1 >= charStringArray.Length || charStringArray[i] != charStringArray[i + 1])

                {
                    compressedString.Append(charStringArray[i]);
                    compressedString.Append(consecutiveCount);
                    consecutiveCount = 0;
                }
            }
            return compressedString.Length < str.Length ? compressedString.ToString() : str;

        }

        static string compressBad(string str)
        {
            string compressedString = string.Empty;
            int consecutiveCount = 0;
            char[] charStringArray = str.ToCharArray();

            for (int i=0;i< charStringArray.Length;i++)
            {
                consecutiveCount++;

                if(i+1>=charStringArray.Length || charStringArray[i]!=charStringArray[i+1])

                {
                    compressedString += "" + charStringArray[i] + consecutiveCount;
                    consecutiveCount = 0;
                }
            }
            return compressedString.Length < str.Length ? compressedString : str;

        }
    }
}
