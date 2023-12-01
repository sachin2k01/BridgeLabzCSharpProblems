using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter an Array Elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < size;i++)
            {
                int num = array[i];
                bool res=prime(num);
                if (res==true)
                {
                    Console.WriteLine($"{array[i]} is a prime Number");
                }
            }
        }

        public static bool prime(int n)
        {
            if (n == 0 || n==1)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else
            {
                for(int i=2; i<n; i++)
                {
                    if(n%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
