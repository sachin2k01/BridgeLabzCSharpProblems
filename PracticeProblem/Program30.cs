using System;


namespace PracticeProblem
{
    class Program30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Parent class");
            Arithmetic ar=new Arithmetic();
            ar.Addition();
            Console.WriteLine("Calling child  class");
            Arithmetic2 a= new Arithmetic2();
            a.Add();
        }
    }
    internal class Arithmetic
    {
        public int num1 = 20;
        public int num2 = 40;
        public void Addition()
        {
            int res=num1 + num2;
            Console.WriteLine("Addition in Parent class: "+res);
        }
    }

    internal class Arithmetic2 : Arithmetic
    {
        public void Add()
        {
            int result = num1 + num2;
            Console.WriteLine("Addition in Child class : "+result);
        }
    }
}
