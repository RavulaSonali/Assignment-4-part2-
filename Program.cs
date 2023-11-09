using System;


namespace Assignment_4_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("First 10 Natural Numbers:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");

            }

            //EVEN NUMBER
            Console.WriteLine("\n\nFirst 10 Even Natural Numbers:");
            int evenCounter = 1;
            while (evenCounter <= 20)
            {
                if (evenCounter % 2 == 0)
                {
                    Console.Write($"{evenCounter} ");
                    evenCounter++;
                }
                else
                {
                    evenCounter++;
                }
            }

            // ODD NUMBER
            Console.WriteLine("\n\nFirst 10 Odd Natural Numbers:");
            int oddCounter = 1;
            do
            {
                if (oddCounter % 2 != 0)
                {
                    Console.Write($"{oddCounter} ");
                }
                oddCounter++;
            } while (oddCounter <= 20);

            Console.ReadLine(); 

        }
    }
}
