using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ProductValidate
{
    public class Product
    {
        [Required(ErrorMessage ="Product Id is Required")]
        public int ProductId {  get; set; }

        [Required(ErrorMessage ="Product Name is Required")]
        [StringLength(50,ErrorMessage ="Product Name should be Less than 50 Character")]
        public string ProductName { get; set; }

        [Range(0,double.MinValue,ErrorMessage ="price should be a Positive Number")]
        public double price {  get; set; }  

        public DateTime CreatedAt { get; set; }= DateTime.Now;

    }
}
