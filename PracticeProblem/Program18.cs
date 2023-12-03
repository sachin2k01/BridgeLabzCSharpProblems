using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array size");
            int size=int.Parse(Console.ReadLine());
            int[] ar=new int[size];
            Console.WriteLine("Enter an Element to Insert With 0 included");
            for(int i=0; i<size; i++)
            {
                ar[i]=int.Parse(Console.ReadLine());
            }
           
            int[] arr1= new int[ar.Length];
            int k = 0;
            for (int i=0; i<size;i++)
            {
                if (ar[i]!=0)
                {
                    arr1[k] = ar[i];
                    k++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (ar[i] == 0)
                {
                    arr1[k] = ar[i];
                    k++;
                }
            }

            Console.WriteLine("Array ELements After Rearange");
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
