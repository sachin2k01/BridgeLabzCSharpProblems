using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    class Program7
    {
        static void Main(string[] args)
        {
            Circle c=new Circle();
            Console.WriteLine("Enter a radius of the circle");
            int r=int.Parse(Console.ReadLine());
            c.Perimeter(r);
            c.Area(r);
        }
    }

    internal class Circle
    {
        public void Perimeter(double r)
        {
            double peri = 2 * r * Math.PI;
            Console.WriteLine("Perimeter of the Circle is: " + peri);
        }

        public void Area(double r)
        {
            double area = Math.PI * r*r;
            Console.WriteLine("Area of the Circle is: " + area);
        }
    }
}
