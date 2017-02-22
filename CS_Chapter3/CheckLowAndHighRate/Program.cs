using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            const double HIGH = 49.99;

            const double LOW = 5.65;

            double HourlyPayRate;


            Console.Write("Enter your hourly pay rate:");

            HourlyPayRate = Convert.ToDouble(Console.ReadLine());






            if (HourlyPayRate > HIGH) ;

            Console.WriteLine("The amount entered is to much");


    else

    if (HourlyPayRate < LOW) ;
            
    Console.WriteLine("The amount you entered is to small");

        }
    }
}
