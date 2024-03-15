using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{


    [Table("Advertisements")]
    public class Advertisement
    {
        public int id { get; set; }
        
        [Display(Name = "اسم المنتج")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "مسار الصورة  ")]
        public string Photo_Advertisement { get; set; }
        
        [Display(Name = "الترتيب")]
        public int order { get; set; }

        public DateTime dateTime { get; set; }

    }
}
