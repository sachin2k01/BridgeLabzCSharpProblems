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
            RO.ValidateEmail();
            RO.ValidatePassword();



        }
    }
}
