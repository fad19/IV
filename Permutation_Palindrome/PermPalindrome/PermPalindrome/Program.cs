using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.isPermutationOfPalindrome("tactcoapapa")); // ("civil"));
            Console.ReadLine();
            
        }

        static Boolean isPermutationOfPalindrome(string phrase)
        {
            int[] table = buildCharFrequencyTable(phrase);
            return checkMaxOneOdd(table);
        }

        static bool checkMaxOneOdd(int[] table)
        {
            Boolean foundOdd = false;
            foreach (int count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }
            return foundOdd;
        }

        /* Map each character to a number. a -> 0, b -> 1, c -> 2, etc.
                                                                        * This is case insensitive. Non-letter characters map to -1. */
      static  int getCharNumber(char c)
        {
            int a = 'a';
            int z = 'z';
            int val =c;
            if (a <= val && val <= z)
            {
                return val - a;
            }
            return -1;
        }

        /* Count how many times each character appears. */

       static int[] buildCharFrequencyTable(string phrase)
        {

            int[] table = new int[('z' - 'a'+ 1)];

            foreach (char c in phrase.ToCharArray())
            {
                int x = getCharNumber(c);

                if (x != -1)
                {
                    table[x]++;
                }
            }
            return table;
        }
    }
}
