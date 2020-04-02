using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_6._1.Models
{
    public class AssignmentPerson
    {
        [Display (Name = "First Name")]
        [MaxLength(25)]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(25)]
        [MinLength(2)]
        [Required]
        public string LastName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer")]
        public int Age { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        public Countries Country { get; set; }
    }
}
