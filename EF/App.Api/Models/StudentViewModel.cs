using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Api.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name requred")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Email requred")]
        public string Email { get; set; }
        public DateTime? RegDate { get; set; }
        [Required(ErrorMessage = "Dob")]
        public DateTime? Dob { get; set; }
        [Required(ErrorMessage = "Phone number requred")]
        public string Phone { get; set; }
    }
}