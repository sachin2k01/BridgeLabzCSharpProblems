using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation
{
    public class Person
    {
        [Required(ErrorMessage ="Name is Required")]
        [StringLength(50, ErrorMessage ="Name Should be Less than 50 characters")]
        [Display(Name ="Full Name")]
        public string Name { get; set; }

        [Range(18,65, ErrorMessage ="Age should be between 18 and 65")]
        public int Age {  get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",ErrorMessage = "Invalid email format.")]
        public string Email {  get; set; }

    }
}
