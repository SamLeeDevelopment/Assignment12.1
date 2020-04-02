using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Data;

namespace Assignment_6._1.Models
{
    public class CreatePersonCommand : EditPersonBase
    {
        public IList<CreateAccomplishmentCommand> Accomplishments { get; set; } = new List<CreateAccomplishmentCommand>();

        public Person ToPerson()
        {
            return new Person
            {
                FirstName = FirstName,
                LastName = LastName,
                City = City,
                State = State,
                DateOfBirth = DateOfBirth,
                Accomplishments = Accomplishments?.Select(x => x.ToAccomplishment()).ToList()
            };
        }
    }
}
