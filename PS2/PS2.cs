using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    internal class PS2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Choice which Operation you want ");
            Console.WriteLine("1. For Converting temperature Fahrenheit to Celicus");
            Console.WriteLine("2. For Converting temperature Celcius to fahrenheit");
            Console.WriteLine("0. For Exit");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 0: Environment.Exit(0); break;
                case 1:
                    Console.WriteLine("Enter the Temperature of fahrenheit ");
                    int f=int.Parse(Console.ReadLine());
                    double celcius =(5 * (f - 32))/9;
                    Console.WriteLine($"Celcius is: {celcius}");
                    break;
                case 2:
                    Console.WriteLine("Enter a Temperature of celcius");
                    int c=int.Parse(Console.ReadLine());
                    float fahrenheit = 9 / 5 * (c + 32);
                    Console.WriteLine($"Fahrenheit is: {fahrenheit}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;                 
            }
        }
    }
}
