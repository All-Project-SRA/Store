using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    // تلفزيون
    [Table("Products")]
    public class Product
    {

        public int id { get; set; }

        [Required]
        [Display(Name = " الصنف الفرعي")]

        public Categorie_D categorie { get; set; }


        public IdentityUser identityUser  { get; set; }

        [Required]
        [Display(Name = "اسم المنتج")]

        public string Name { get; set; }

       
        [Display(Name = "السعر")]

        public double Price { get; set; }

        [Required]
        [Display(Name = "الوصف")]

        public string Description { get; set; }

        [Display(Name = "مسار الصورة ")]
        public string PhotoPath { get; set; }


        public DateTime dateTime { get; set; }


    }
}
