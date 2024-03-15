using System;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Value_Propertie
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "قيم الخاصية ")]

        public string Value { get; set; }

        public Propertie propertie { get; set; }

        public DateTime dateTime { get; set; }
    }
}
