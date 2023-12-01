using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number How many friends names to insert ");
            int size=int.Parse(Console.ReadLine());
            string[] names=new string[size];
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("Your Friends Names Are");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
