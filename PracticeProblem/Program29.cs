using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers Between 1 to 100");
            Program29 pp=new Program29();
            for(int i = 1; i <=100;i++)
            {
                bool res=pp.prime(i);
                if(res==true)
                {
                    Console.WriteLine($"{i} is a Prime Number");
                }
            }
        }

        public bool prime(int n)
        {
            if(n == 0 || n == 1)
            {
                return false;
            }
            else if(n == 2)
            {
                return true;
            }
            else
            {
                for(int i=2;i<n;i++)
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
