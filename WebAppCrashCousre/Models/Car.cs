using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCrashCousre.Models
{
    public class Car
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Brand { get; set; }

        [Required]
        [Display(Name ="Model")]
        [StringLength(100, MinimumLength = 1)]
        public string ModelName { get; set; }

        /*
        int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
        }
        */

        public Car()
        {

        }

        public Car(string brand, string modelName)
        {
            Brand = brand;
            ModelName = modelName;
        }
    }
}
