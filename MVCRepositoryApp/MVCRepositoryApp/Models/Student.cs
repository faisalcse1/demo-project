using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRepositoryApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email should be valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter reg no.")]
        public string RegNo { get; set; }

    }
}