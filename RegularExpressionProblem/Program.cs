using System.Text.RegularExpressions;

namespace RegularExpressionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hey Hello I'am Sachin B N and My Phone no is 94492-54260";
            ReguExOperation RO = new ReguExOperation();
            RO.SearchName(text);
            RO.ValidatePhoneNo();
            RO.FindNameWithFirstLetter();
            RO.DobValidation();




            //Regex rg= new Regex(@"\b\w{9}\b");
            //Console.WriteLine(rg.Match(text.ToLower()));



            //string phone = "My Phone Number is:  944-94-54260";

            //string pattern = @"\b\d{3}-\d{2}-\d{5}\b";
            //Regex r1= new Regex(pattern);

            //Console.WriteLine(r1.Match(phone));




        }
    }
}
