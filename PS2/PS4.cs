using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    internal class PS4
    {
        static void Main(string[] args)
        {
            string username = "Sachin019";
            string password = "Sachin@2001";
            Console.WriteLine("Welcome to Login Page");
            Console.WriteLine("Enter Your User Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string pass=Console.ReadLine();

            if(name==username &&  pass==password)
            {
                Console.WriteLine("Successfully login");
            }
            else if(name==username && pass!=password)
            {
                Console.WriteLine("Invlaid Password enter correctly");
            }
            else if(pass==password && name!=username)
            {
                Console.WriteLine("Incorrect user name enter correct one");
            }
            else if(name!=username && pass!=password)
            {
                Console.WriteLine("Locked!");
            }
            else
            {
                Console.WriteLine("Invalid Credentials!!");
            }
        }
    }
}
