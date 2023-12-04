using System;

namespace PracticeProblem
{
    internal class Program28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Find a square root of the Number");
            int num = int.Parse(Console.ReadLine());
            Program28 p=new Program28();
            p.findsqrt(num);

        }

        public void findsqrt(double num)
        {
            if (num < 2)
            {
                Console.WriteLine("Square root of enterd number is : " + num);
            }
            double x = num;
            double y = (x + (num / x)) / 2;

            while (Math.Abs(x - y) >= 0.00001)
            {
                x = y;
                y = (x + (num / x)) / 2;

            }
            Console.WriteLine("Square root of enterd number is : " + y);
        }
    }
 }
  
