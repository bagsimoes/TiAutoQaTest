using System;

namespace Tech_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Tech Task");
            // Declare variables and then initialize to zero.
            int xA = 0;
            int yA = 0;
            int xB = 0;
            int yB = 0;
            int xC = 0;
            int yC = 0;

            double perimeter = 0;


            // Display title as the C# console calculator app.
            Console.WriteLine("Enter coordinate x of dot A\r");
            xA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A\r");
            yA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot B\r");
            xB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B\r");
            yB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter coordinate x of dot C\r");
            xC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C\r");
            yC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.

            double aB = Math.Sqrt((Math.Pow(xA - xB, 2)) + (Math.Pow(yA - yB, 2)));
            Console.WriteLine($"Length of AB is: " + aB);
            double bC = Math.Sqrt((Math.Pow(xB - xC, 2)) + (Math.Pow(yB - yC, 2)));
            Console.WriteLine($"Length of BC is: " + bC);
            double aC = Math.Sqrt((Math.Pow(xA - xC, 2)) + (Math.Pow(yA - yC, 2)));
            Console.WriteLine($"Length of AC is: " + aC);


            if ((aB == bC) && (bC == aC) && (aB == aC))
            {
                Console.WriteLine("Triangle IS 'Equilateral' ");
            }
            else Console.WriteLine("Triangle IS NOT 'Equilateral' ");

            if ((aB == bC) || (bC == aC) || aB == aC)
            {
                Console.WriteLine("Triangle IS 'Isosceles' ");
            }
            else Console.WriteLine("Triangle IS NOT 'Isosceles' ");

            if ((aB > bC ) && (aB > aC))
            {
                if (Math.Pow(aB, 2) == (Math.Pow(bC, 2) + Math.Pow(aC, 2)))
                {
                    Console.WriteLine("Triangle IS 'Right' ");
                }
                else Console.WriteLine("Triangle IS NOT 'Right' ");
                
            }
       


            if ((bC > aB) && (bC > aC))
            {
                if (Math.Pow(bC, 2) == (Math.Pow(aB, 2) + Math.Pow(aC, 2)))
                {
                    Console.WriteLine("Triangle IS 'Right' ");
                }
                else Console.WriteLine("Triangle IS NOT 'Right' ");

            }
           


            if ((aC > bC) && (aC > aB))
            {
                if (Math.Pow(aC, 2) == (Math.Pow(bC, 2) + Math.Pow(aB, 2)))
                {
                    Console.WriteLine("Triangle IS 'Right' ");
                }
                else Console.WriteLine("Triangle IS NOT 'Right' ");

            }
           

            perimeter = aB + bC + aC;

            Console.WriteLine("Perimeter: '" + perimeter + "'");

            for (int i=0; i < perimeter; i++) {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "\t");

                }
            }

            Console.ReadKey();

        }
    }
}
