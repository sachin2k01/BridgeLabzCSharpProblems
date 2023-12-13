using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    internal class PS5
    {
        static void Main(string[] args)
        {
            ArithOperation op=new ArithOperation();
            while(true)
            {
                Console.WriteLine("1. for addition");
                Console.WriteLine("2. for subtraction");
                Console.WriteLine("3. for multiplication");
                Console.WriteLine("4. for division");
                Console.WriteLine("0. for exit");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0: Environment.Exit(0); break;
                    case 1:int sum=op.add();
                        Console.WriteLine("sum of number is: "+sum);
                        break;
                    case 2:
                        int sub = op.sub();
                        Console.WriteLine("subtraction of Number is: "+sub);
                        break;
                    case 3:
                        int mul = op.mul();
                        Console.WriteLine("Multiplication of number is: "+mul);
                        break;
                    case 4:
                        int div = op.div();
                        Console.WriteLine("division of number is: "+div);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }

    public class ArithOperation
    {
        public int add()
        {
            Console.WriteLine("Enter first Number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sec Number");
            int n2=int.Parse(Console.ReadLine());
            return n1+n2;
        }

        public int sub()
        {
            Console.WriteLine("Enter first Number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sec Number");
            int n2=int.Parse(Console.ReadLine()) ;
            return n1 - n2;
        }

        public int mul()
        {
            Console.WriteLine("Enter first Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int n2=int.Parse(Console.ReadLine()) ;
            return n1 * n2;
        }

        public int div()
        {
            Console.WriteLine("Enter first Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int n2 = int.Parse(Console.ReadLine());
            return n1 / n2;

        }
    }
}
