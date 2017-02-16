using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your spending limit: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose between Pine(p), Oak(o), Mahoganhi(m): ");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "p":
                    Console.WriteLine("Number of tables (Pine): {0}", b % 100);
                    break;
                case "o":
                    Console.WriteLine("Number of tables (Oak): {0}", b % 225);
                    break;
                case "m":
                    Console.WriteLine("Number of tables (Mahoganhi): {0}", b % 310);
                    break;
                default:
                    Console.WriteLine("Incorrect input");
                    break;
            }
            //Delay
            Console.ReadKey();
        }
    }
}
