using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2 = double.Parse(Console.ReadLine());

            double sum=num1+num2;
            double diffrence=num1-num2;

            double sumofsquare=Math.Pow(sum,2);
            double diffsquare=Math.Pow(diffrence,2);

            Console.WriteLine($"Square of sum of the two number is {sumofsquare}");
            Console.WriteLine($"square of diffrence of two number is {diffsquare}");
        }

    }
}
