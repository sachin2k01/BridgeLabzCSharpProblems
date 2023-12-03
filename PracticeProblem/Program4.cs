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
            string num = Console.ReadLine();

            int val = int.Parse(num);

            int res = val * 10;
            string str=res.ToString();
            Console.WriteLine($"the value 10 times print as string is: {str}");
        }
            
    }
}
