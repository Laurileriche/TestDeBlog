using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeBlog.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Enter your name please")]
        [Display(Name = "Name")]
        public string Nom { get; set; }

      
        [Required(ErrorMessage = "Enter your content please")]
        [Display(Name = "Content")]
        public string Content { get; set; }


        [Display(Name = "Date Crée: ")]
        public DateTime DateFacturation { get; set; }


        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
