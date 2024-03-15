using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    // الكترونيات
    [Table("Categories")]
    public class Categorie
    {
 
        public int id { get; set; }
        [Required]
        [Display(Name = "اسم الصنف")]

        public string Name { get; set; }
        [Required]
        [Display(Name = "الترتيب")]
        public int order { get; set; }

        public virtual List<Categorie_M> Catgories_M { get ; set; }

        public DateTime dateTime { get; set; }
    }
}
