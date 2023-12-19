using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductValidation2
{
    public class Products
    {
        [Required(ErrorMessage = "Product ID is required.")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price should be a positive number.")]
        public decimal Price { get; set; }

        [DiscountLessThanPrice(ErrorMessage="Discount Should be Less Than Price")]
        public decimal Discount { get; set; }
    }
    public class DiscountLessThanPrice : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (Products)validationContext.ObjectInstance;
            decimal discount = (decimal)value;

            if (discount > product.Price)
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
