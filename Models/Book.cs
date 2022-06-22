using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]

        [Required(ErrorMessage ="Id Required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Author Name Required")]
        [MaxLength(20)]
        public string AutherName { get; set; }

        [Required(ErrorMessage = "Pulisher Name Required")]
        [MaxLength(40)]
        public string PublisherName { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Range(minimum:100, maximum:1000, ErrorMessage ="Price must be between 100 to 1000")]

        public double Price { get; set; }

    }
}