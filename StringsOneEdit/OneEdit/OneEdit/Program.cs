using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.OneWayEdit("pale", "pae"));
            Console.ReadLine();
        }

        static Boolean OneWayEdit(string first,string second)
        {
            if(first.Length==second.Length)
            {
                return oneEditReplace(first, second);
            }
            else if (first.Length+1 == second.Length)
            {
                return oneEditInsert(first, second);
            }
            else if (first.Length -1  == second.Length)
            {
                return oneEditInsert( second, first);
            }

            return false; 
        }

        private static bool oneEditInsert(string first, string second)
        {
            int index1 = 0;
            int index2 = 0;
            char[] firstArray = first.ToCharArray();
            char[] secondArray = second.ToCharArray();

            while (index2 < secondArray.Length && index1 < firstArray.Length )
            {
                if (firstArray[index1] != secondArray[index2])
                {
                    if(index1!=index2)   //if more than one ocurrence of a different character , return false straight away. 
                    {
                        return false;
                    }
                    index2++; //when the different char is in start 
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        private static bool oneEditReplace(string first, string second)
        {
            Boolean foundDifference = false;
            char[] firstArray = first.ToCharArray();
            char[] secondArray = second.ToCharArray();

            for (int i=0;i<first.Length;i++)
            {
                if (firstArray[i]!= secondArray[i])
                {
                    if(foundDifference) //if more than one ocurrence of a different character , return false straight away. 
                    {
                        return false; 
                    }
                    foundDifference = true;
                }
            }

            return foundDifference;
        }
    }
}
