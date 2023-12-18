using System.ComponentModel.DataAnnotations;
namespace DataAnnotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 25;
            person.Name = "Sachin";
            person.Email = "Sachin@gmail.com";

            var validate=new ValidationContext(person);
            var validateresult=new System.Collections.Generic.List<ValidationResult>();

            bool Isvalid=Validator.TryValidateObject(person, validate,validateresult,true);
            if (Isvalid == true)
            {
                Console.WriteLine("Validation Passed");
            }
            else
            {
                Console.WriteLine("Validation Failed");
                foreach (ValidationResult result in validateresult)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }


        }
    }
}
