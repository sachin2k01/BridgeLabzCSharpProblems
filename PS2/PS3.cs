using System;
using System.Collections.Generic;


namespace PS2
{
    internal class PS3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the time of the movie in hours(ex: for 9AM=900, for 2PM=1400)");         //in 100 format for 1pm =1300  13*100, for 5pm= 1700
            int hours=int.Parse(Console.ReadLine());

            int childticket = 40;
            int adultticket = 100;
            int seniorticket = 80;
            int matineediscount = 20;

            int ticket = 0;

            if(age <= 0 )
            {
                Console.WriteLine("Invalid Input enter correct age");
            }

            if(age<=12)
            {
                ticket = childticket;
                Console.WriteLine("Your Ticket price is: " + ticket);

            }
            else if(age>12 ||  age<=64 )
            {
                ticket = adultticket;
                Console.WriteLine("Your Ticket price is: " + ticket);
            }
            else if(age > 12 || age <= 64 && hours>=1700)
            {
                ticket = adultticket - matineediscount;
                Console.WriteLine("Your Ticket price is: " + ticket);
            }
            else if( age> 64 && hours>1700)
            {
                ticket = seniorticket - matineediscount;
                Console.WriteLine("Your Ticket price is: " + ticket);
            }
            else
            {
                ticket = seniorticket;
                Console.WriteLine("Your Ticket price is: " + ticket);
            }

            
        }
    }
}
