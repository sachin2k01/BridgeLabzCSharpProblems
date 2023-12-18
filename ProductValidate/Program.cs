using System.ComponentModel.DataAnnotations;

namespace ProductValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.price = 1459;
            product.ProductName = "Watch";
            product.ProductId = 54;
            product.CreatedAt = DateTime.Now;

            var productvalidate=new ValidationContext(product);
            var validateresult=new System.Collections.Generic.List<ValidationResult>();

            bool iSvalid=Validator.TryValidateObject(product,productvalidate,validateresult);

            if (iSvalid)
            {
                System.Console.WriteLine("Product are valid");
            }
            else
            {
                {
                    System.Console.WriteLine("Not a Valid Product");
                    foreach(var item in validateresult)
                    {
                        System.Console.WriteLine(item.ErrorMessage);
                    }
                }
            }
        }
    }
}
