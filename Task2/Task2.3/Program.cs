using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 },
                                         { 4, 5, 6 },
                                         { 7, 8, 9 } };

            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            int[,] newMatrix = new int[numRows, numCols];

            Console.WriteLine("Initial Matrix");

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("New Matrix:");

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (i == j)
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                    if (i > j)
                    {
                        newMatrix[i, j] = 0;
                    }
                    if (i < j)
                    {
                        newMatrix[i, j] = 1;
                    }

                }
            }

            for (int i = 0; i < newMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        }
    }
