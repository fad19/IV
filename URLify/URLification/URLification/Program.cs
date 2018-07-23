using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLification
{
    class Program
    {
        static void Main(string[] args)
        {
            replaceString("Mr Smith Jhon    ", 13);
        }

        static void replaceString(string str, int trueLength)
        {
            int spaceCount = 0;int index = 0;int i = 0; string result=string.Empty  ;
            char[] originalCharArray = str.ToCharArray();

            for( i=0; i< trueLength;i++)
            {
                if(originalCharArray[i]==' ')
                {
                    spaceCount++;
                }
            }

            index = trueLength + spaceCount * 2;

            if (trueLength < originalCharArray.Length) originalCharArray[trueLength] = '\0';

            for(i=trueLength-1; i>=0; i--)
            {
                if(originalCharArray[i]==' ')
                {
                    originalCharArray[index - 1] = '0';
                    originalCharArray[index - 2] = '2';
                    originalCharArray[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    originalCharArray[index-1] = originalCharArray[i];
                    index--;
                }
            }
            foreach (char j in originalCharArray)
            {
               
                 result  = result + j.ToString();
             
            }
            Console.WriteLine("URLyfined String: " + result);
            Console.ReadLine();

        }
    }
}
