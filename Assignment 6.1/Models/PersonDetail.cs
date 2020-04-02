using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Models
{
    public class PersonDetailViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string DateOfBirth { get; set; }

        public IEnumerable<Item> Accomplishments { get; set; }

        public class Item
        {
            public string Name { get; set; }
            public string DateOfAccomplishment { get; set; }
        }
    }
}
