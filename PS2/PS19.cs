using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public class PS19
    {
        static void Main(string[] args)
        {
            List<Products> product = new List<Products>()
            {
                new Products{ productid = 101, ProductName = "Mouse", price=270},
                new Products{ productid = 101, ProductName = "Mobile", price=270},
                new Products{ productid = 102, ProductName = "Keyboard", price=500},
                new Products{ productid = 100, ProductName = "Pen", price=20},
                new Products{ productid = 104, ProductName = "Mobile", price=25000},
                new Products{ productid = 103, ProductName = "Desktop", price=32000},
                new Products{ productid = 108, ProductName = "Bike", price=200000},
                new Products{ productid = 105, ProductName = "cable", price=200}
            };

            Console.WriteLine("counting the products of Mobile ");
            var ls = product.FindAll(x => (x.ProductName == "Mobile"));
            Console.WriteLine(ls.Count);
            Console.WriteLine();

            

            var sortprice=product.OrderBy(x=>x.price).ToList();
            Console.WriteLine("Sorting the product based on the Price");
            foreach(var cost in sortprice)
            {
                Console.WriteLine($"Product id: {cost.productid}  Product Name: {cost.ProductName}  price: {cost.price} ");
            }


            var lin = (from cs in product.OrderBy(x => x.price) select cs);
            Console.WriteLine("Using Linq Method");
            foreach(var cot in lin)
            {
                Console.WriteLine(cot.ProductName);
            }

        }
    }

    public class Products
    {
        public string ProductName {  get; set; }
        public int productid { get; set; }
        public int price {  get; set; }


    }
}
