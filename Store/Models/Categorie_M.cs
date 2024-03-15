using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    // اغراض منزل 
    [Table("Categories_M")]
    public class Categorie_M
    {

        public int id { get; set; }


        [Required]
        [Display(Name = " الصنف الفرعي")]

        public List<Categorie_D> Catgories_D { get; set; }

        [Required]
        [Display(Name = " الصنف الأساسي")]

        public virtual Categorie categorie { get; set; }



        [Required]
       [Display(Name = "اسم الصنف")]

       public string Name { get; set; }


        [Required]
        [Display(Name = "الترتيب")]
        public int order { get; set; }

        public DateTime dateTime { get; set; }

    }
}
