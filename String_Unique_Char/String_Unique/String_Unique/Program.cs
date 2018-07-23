using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Unique
{
    class Program
    {
        static bool HasUniqueCharacters(string s)
        {
           // string lowercase = s.ToLower();
            if (s.Length > 128)
                return false;
            Boolean[] char_set = new Boolean[128];
           
            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i];
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str = "fAhad";

         
            Console.WriteLine(Program.HasUniqueCharacters(str).ToString());
            Console.ReadLine();
        }
    }
}
