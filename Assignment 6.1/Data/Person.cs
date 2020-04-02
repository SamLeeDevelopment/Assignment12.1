using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Data
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Accomplishment> Accomplishments { get; set; }
    }
}
