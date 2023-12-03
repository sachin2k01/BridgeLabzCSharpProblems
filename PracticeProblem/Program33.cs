using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size=int.Parse(Console.ReadLine());
            int[] ar=new int[size];
            Console.WriteLine("Enter Array elements to Count sum of its number");
            for(int i=0; i<size; i++)
            {
                ar[i]=int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach(int i in ar)
            {
                sum+=i;
            }
            Console.WriteLine($"Sum of the Array elements is :{sum}");
        }
    }
}
