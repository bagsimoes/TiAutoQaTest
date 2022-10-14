using System;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Input the size of the array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Input int values of the array");

            for (int i=0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] auxArray = new int[array.Length];

            for (int j= 0; j < array.Length; j++)
            {
                auxArray[j] = array[array.Length - j - 1];

            }

            Console.WriteLine("[{0}] Initial Array", string.Join(", ", array));
            Console.WriteLine("[{0}] Swapped Array", string.Join(", ", auxArray));

        }
    }
}
