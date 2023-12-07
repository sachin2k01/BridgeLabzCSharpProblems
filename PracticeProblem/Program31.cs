using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in celcius");
            float c=float.Parse(Console.ReadLine());

            float f = c*(9 / 5) * 32;
            float k = c + 273.15f;

            Console.WriteLine($"Temperature in Fahreneit is: {f}");
            Console.WriteLine($"Temperature in kelvin is: {k}");
        }
    }
}
