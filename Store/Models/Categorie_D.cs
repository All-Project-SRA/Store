using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    // تلفزيونات
    [Table("Categories_D")]
    public class Categorie_D
    {
        
        public int id { get; set; }
       
        [Display(Name = "خصائص المنتج")]

        public string id_Properties { get; set; }


        [Required]
        [Display(Name = " الصنف الفرعي")]

        public Categorie_M categorie { get; set; }


        [Required]
        [Display(Name = " الأصناف ")]

        public List<Product> Products { get; set; }

        [Required]
        [Display(Name = "اسم الصنف")]

        public string Name { get; set; }


        [Required]
        [Display(Name = "الترتيب")]
        public int order { get; set; }


        public DateTime dateTime { get; set; }

    }
}
