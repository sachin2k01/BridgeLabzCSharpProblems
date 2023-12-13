using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public class PS18
    {
        static void Main(string[] args)
        {

            List<Orders> orders = new List<Orders>()
            {
                new Orders{ ProductName="laptop", ProductCategory="electronics", Price=234000},
                new Orders{ ProductName="Hair dye", ProductCategory="Beauty", Price=240 },
                new Orders{ ProductName="TV" , ProductCategory="electronics",Price=20000},
                new Orders{ ProductName="Shoes" , ProductCategory="fashion",Price=2000},
                new Orders{ ProductName="football", ProductCategory="sports", Price=1000},
                new Orders{ ProductName="dumbell", ProductCategory="sports", Price=1500},
                new Orders{ ProductName="sunscream", ProductCategory="Beauty", Price=500},
                new Orders{ ProductName="mouse", ProductCategory="electronics", Price=600},
            };

            var product = orders.OrderBy(x => x.ProductCategory).ToList();
            Console.WriteLine("List the Orders by Product category");
            foreach (var item in product)
            {

                Console.Write("product category: " + item.ProductCategory + "  product name:" + item.ProductName + "    product price: " + item.Price);
                Console.WriteLine();
            }
            Console.WriteLine();


            //var cou = orders.Select(x => x.ProductCategory).Distinct().Count();
            //Console.WriteLine(cou);
        }
    }

    public class Orders
    {
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int Price {  get; set; }

    }


}
