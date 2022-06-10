using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DataLayer.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Family { get; set; }

        [MaxLength(100,ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }
    }
}
