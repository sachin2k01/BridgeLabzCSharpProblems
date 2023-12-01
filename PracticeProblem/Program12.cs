using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing Number from 1 to 100");
            int i = 1;
            NumPrint(i);
        }

        public static void NumPrint(int n)
        {
            if(n <= 100)
            {
                Console.Write(n+ " ");
                 NumPrint(n+1);
            }

        }
    }
}
