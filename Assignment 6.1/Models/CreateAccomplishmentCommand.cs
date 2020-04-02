using Assignment_6._1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Models
{
    public class CreateAccomplishmentCommand
    {
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Date of Accomplishment")]
        public string DateOfAccomplishment { get; set; }

        public Accomplishment ToAccomplishment()
        {
            return new Accomplishment
            {
                Name = Name,
                DateOfAccomplishment = DateOfAccomplishment,
            };
        }
    }
}
