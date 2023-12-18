using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionProblem
{
    public class ReguExOperation
    {
        public void SearchName(string name)
        {
            string text = name;
            string pattern = @"\bSachin\b";
            Regex rg1=new Regex(pattern);
            bool res=rg1.IsMatch(text);
            if(res)
                Console.WriteLine("Name Found");
            else
                Console.WriteLine("Name Not Found");
            Console.WriteLine();
           
        }

        public void ValidatePhoneNo()
        {

            Console.WriteLine("enter your Number to Check its Valid or Not(ex: 12345-65432)");
            string phone = Console.ReadLine();
            string patternNo = @"\b\d{5}-\d{5}";
            Regex rg2=new Regex(patternNo);
            bool phNo=rg2.IsMatch(phone);
            if (phNo)
                Console.WriteLine("Valid Phone No");
            else
                Console.WriteLine("Not a valid Number");
            Console.WriteLine();
        }

        public void FindNameWithFirstLetter()
        {
            
            string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";

            string namepattern = @"\b[M]\w+";
            Regex rg1=new Regex(namepattern,RegexOptions.IgnoreCase);

            MatchCollection matchnames= rg1.Matches(authors);

            for(int i=0; i<matchnames.Count; i++)
            {
                Match match = matchnames[i];
                Console.WriteLine(match);
            }
            Console.WriteLine();
        }

        public void DobValidation()
        {
            Console.WriteLine("Enter Date of Birth to Validate( 24-JAN-2000)");
            string DOB=Console.ReadLine();

            string pattern = @"[0-9]{2}-[A-Z]{3}-[0-9]{4}$";

            Regex rg2=new Regex(pattern);
            Console.WriteLine(rg2.IsMatch(DOB.ToUpper()));
        }

        public void ValidateEmail()
        {
            Console.WriteLine("Enter an email id to validate");
            string email = Console.ReadLine();


            string pattern = @"^[a-z]{1}[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$";

            bool res=Regex.IsMatch(email, pattern);

            if (res)
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invalid Email");
        }

        public void ValidatePassword()
        {
            Console.WriteLine("Enter an Password");
            string password = Console.ReadLine();
            string pattern = @"^[A-Z]{1,3}\w[a-z0-9!@]{7,}$";
            bool res = Regex.IsMatch(password, pattern);
            if (res) Console.WriteLine("Password is Secured and its Strong");
            else Console.WriteLine("Wrong Enter Strong One");
        }

    }
}
