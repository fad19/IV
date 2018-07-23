using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroMatrix_MxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3]{ { 1, 1, 1},
                                          { 0,1,1 },
                                          {1,1,1}
            };


            SetZeroes(matrix);
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(0); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.ReadLine();
            }
        }

        public static void SetZeroes(int[,] matrix)
        {
            bool[] row = new bool[matrix.Length-1];
            bool[] column = new bool[matrix.Length-1];

            for (int i=0; i<=matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(0); j++)
                {
                    if(matrix[i,j]==0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            // Nullify rows
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i]) nullifyRow(matrix, i);
            }
           
            // Nullify cols
            for (int j= 0; j < column.Length; j++)
            {
                if (column[j]) nullifyCols(matrix, j);
            }
        }

     static void nullifyRow(int[,] matrix, int row)
        {
            for (int j = 0; j <= matrix.GetUpperBound(0); j++)
            {
                matrix[row,j] = 0;
            }
        }

        static void nullifyCols(int[,] matrix, int col)
        {
            for (int j = 0; j <= matrix.GetUpperBound(0); j++)
            {
                matrix[j,col] = 0;
            }
        }
    }

}
