using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Propertie
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "اسم الخاصية ")]

        public string Name { get; set; }

      public List<Value_Propertie> value_Properties { get; set; }

        public DateTime dateTime { get; set; }

    }
}
