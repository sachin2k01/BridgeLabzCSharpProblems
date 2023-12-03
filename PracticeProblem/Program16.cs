using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Program16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the float array size");
            int size=int.Parse(Console.ReadLine());
            float[] arr=new float[size];
            Console.WriteLine("Enter the Float value for an Array");
            for(int i = 0;i<size;i++)
            {
                arr[i]=float.Parse(Console.ReadLine());
            }
            Program16 p=new Program16();

            float res=p.Avg(arr, size);
            Console.WriteLine($"Average of array is :{res}");

        }

        public float Avg(float[] a, int size)
        {
            float avg = 0.0f;
            for(int i=0;i<size;i++)
            {
                avg += a[i];
            }

            float totalavg = avg / size;
            return totalavg;
        }
    }
}
