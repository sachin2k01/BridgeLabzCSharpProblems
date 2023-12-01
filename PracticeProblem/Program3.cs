using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many place you want to visit");
            int size=int.Parse(Console.ReadLine());
            string[] place=new string[size];
            Console.WriteLine("Enter Place You Want Visit");
            for(int i=0; i<size; i++)
            {
                place[i] = Console.ReadLine();
            }
            Console.WriteLine("Your Fav Place in Capital Letter");
            foreach(string cap in  place)
            {
                Console.WriteLine($"{cap.ToUpper()}");
            }
            Console.WriteLine("Your Fav Place in small Letter");
            foreach (string small in place)
            {
                Console.WriteLine($"{small.ToLower()}");
            }
        }
    }
}
