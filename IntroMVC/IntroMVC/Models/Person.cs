using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroMVC.Models
{
    public class Person
    {   
        [Required(ErrorMessage ="Please give your name")]
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Name must be less than 10")]
        public string Name { get; set; }
        [Required]
        public string Dob { get; set; }
    }
}