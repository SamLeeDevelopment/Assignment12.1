using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Data;

namespace Assignment_6._1.Models
{
    public class UpdatePersonCommand : EditPersonBase
    {
        public int Id { get; set; }

        public void UpdateRecipe(Person person)
        {
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.City = City;
            person.State = State;
            person.DateOfBirth = DateOfBirth;
        }
    }
}
