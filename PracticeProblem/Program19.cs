using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Array Size");
            int size=int.Parse(Console.ReadLine());
            int[] array=new int[size];
            Console.WriteLine("Enter an array element to insert repeat element also");
            for(int i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }
            bool flag=false;
            for(int i = 0;i < array.Length-1; i++)
            {
                for(int j = i+1;j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        flag = true;
                        Console.WriteLine("First Repeated elemnt is " + array[i]);
                        break;
                    }
                }
            }
            if(flag==false)
            {
                Console.WriteLine("No Repeated Element is Found");
            }
            
        }
    }
}
