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
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "invalied email address")]
        public string Email { get; set; }
        public DateTime? RegDate { get; set; }
        [Required(ErrorMessage = "Dob")]
        public DateTime? Dob { get; set; }
        [Required(ErrorMessage = "Phone number requred")]
        public string Phone { get; set; }
    }
}