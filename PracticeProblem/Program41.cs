using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    class Program41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Hour to find minute and seconds");
            int hour=int.Parse(Console.ReadLine());

            int minute = hour * 60;
            Console.WriteLine("Minutes: " + minute);
            int second=hour * 3600;
            Console.WriteLine("Seconds :" + second);
        }
    }
}
