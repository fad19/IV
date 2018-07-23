using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation_NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,3]{ { 1, 2, 3},
                                          { 6,7,8 },
                                          {11,12,13}
            };


            rotate(matrix);
            for (int i = 0; i <= matrix.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                   Console.WriteLine(matrix[i, j] + " ");
                }
                Console.ReadLine();
            }
        }


        public static void rotate(int[,] matrix)
        {
            int n = matrix.GetUpperBound(1);


            for (int layer = 0; layer < n/2 ; layer++)
            {
                int first = layer;
                int last = n - layer;

                for (int i = first; i < last ; i++)
                {
                    int offset = i - first;

                    int top = matrix[first, i];

                    matrix[first, i] = matrix[(last - offset), first];

                    matrix[(last - offset), first] = matrix[i, last];


                    matrix[i, last] = top;
                }
            }

        }
    }
       
}
