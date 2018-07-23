using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation_2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Program.permutation("soprio", "iopsor"));   //(fabcdfedfaaa", "abacdaedfaff"));
            Console.ReadLine();
        }


        public static Boolean  permutation(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] arr = new int[256]; // assume character is ASCII
            for (int i = 0; i < s.Length; i++)
            {
                char value = s[i];
                arr[value]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                int value = t[i];
                if (--arr[value] < 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
