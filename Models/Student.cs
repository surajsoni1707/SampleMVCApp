using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }

        [Display(Name="Student Name")]
        [Required(ErrorMessage="Student Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage= "Age is Required")]
        [Range(minimum:18,maximum:60, ErrorMessage ="Age should be between 18 to 60")]
        public int Age { get; set; }


        [Required(ErrorMessage= "City is Required")]
        [MaxLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage= "Email-Id is Required")]
        [DataType(DataType.EmailAddress,ErrorMessage="Enter Valid Email Address")]
        public string EmailId { get; set; }
        [Required(ErrorMessage= "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}