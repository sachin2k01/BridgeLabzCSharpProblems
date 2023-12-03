using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Days to Convert");
            int days=int.Parse(Console.ReadLine());

            int year = days / 365;
            Console.WriteLine($"Years: {year}");

        

            int month = days / 30;
            Console.WriteLine($"Months : {month}");

            int weeks = days/7;
            Console.WriteLine($"Weeks : {weeks}");
        }
    }
}
