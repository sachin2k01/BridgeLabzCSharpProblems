using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number ");
            string num=Console.ReadLine();
            Console.WriteLine("Printing Entered Number 10 Times");
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine(num);
            }
        }
    }
}
