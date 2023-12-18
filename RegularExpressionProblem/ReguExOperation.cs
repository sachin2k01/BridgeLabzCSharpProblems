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
            string phone=Console.ReadLine();
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

            string pattern = @"[0-9]{2}-[A-Z]{3}-[0-9]{4}";

            Regex rg2=new Regex(pattern);
            Console.WriteLine(rg2.IsMatch(DOB.ToUpper()));
        }

    }
}
