using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number To Find Factorial");
            int num=int.Parse(Console.ReadLine());
            int res=Factorial(num);
            Console.WriteLine($"The Factorial of Enterd Number is: {res}");
        }

        public static int Factorial(int n)
        {
            int fact = 1;
            if(n== 0 || n==1)
            {
                return 1;
            }
            else
            {
                for(int i = 1; i <= n; i++)
                {
                    fact*=i;
                }
                return fact;
            }
                
        }
    }
}
