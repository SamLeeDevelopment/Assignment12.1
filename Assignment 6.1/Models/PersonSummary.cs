using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Data;

namespace Assignment_6._1.Models
{
    public class PersonSummaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfAccomplishments { get; set; }

        public static PersonSummaryViewModel FromRecipe(Person person)
        {
            return new PersonSummaryViewModel
            {
                Id = person.PersonId,
                Name = person.FirstName + " " + person.LastName,
                Location = person.City + ", " + person.State,
            };
        }
    }
}
