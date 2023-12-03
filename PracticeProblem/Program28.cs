using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Find a square root of the Number");
            int num = int.Parse(Console.ReadLine());

            if(num <2) 
            {
                Console.WriteLine("Square root of enterd number is :" + num);
            }

            int sroot = ((num) * 1 / 2);
            Console.WriteLine(sroot);
        }
    }
}
