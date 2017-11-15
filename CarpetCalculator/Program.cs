using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a program that calculates the cost of a carpet with length=10 feet width=22 feet and cost persquare foot is 1.99  print the final cost

         

            //length * width* cost per sq ft  so 4 variables necessary

            int length;

            length = 10;

            int width;

            width = 22;

            double sqftCost;

            sqftCost = 1.99;

            double totalCost;

            totalCost = length * width * sqftCost;
            //sqftCost = 10* 22* 1.99


         

            Console.Write("The cost is $");


            Console.WriteLine(totalCost);

            Console.WriteLine("The Cost is {0:C}, totalCost");
            Console.ReadKey();
        
        }
    }
}
