using Assignment_6._1.Data;
using Assignment_6._1.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1
{
    public class PersonService
    {
        readonly AppDbContext _context;
        readonly ILogger _logger;
        public PersonService(AppDbContext context, ILoggerFactory factory)
        {
            _context = context;
            _logger = factory.CreateLogger<PersonService>();
        }

        public ICollection<PersonSummaryViewModel> GetPeople()
        {
            return _context.People
                .Where(r => !r.IsDeleted)
                .Select(x => new PersonSummaryViewModel
                {
                    Id = x.PersonId,
                    Name = x.FirstName + " " + x.LastName,
                    Location = x.City + ", " + x.State,
                })
                .ToList();
        }

        //Assignment 11.1
        public ICollection<ErrorSummaryViewModel> GetErrors()
        {
            return _context.ErrorLog
                .Select(x => new ErrorSummaryViewModel
                {
                    Id = x.ErrorId,
                    HttpStatusCode = x.HttpStatusCode,
                    ExceptionMessage = x.ExceptionMessage,
                    TimeOfError = x.TimeOfError,
                })
                .ToList();
        }
        //--

        public PersonDetailViewModel GetPersonDetail(int id)
        {
            return _context.People
                .Where(x => x.PersonId == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new PersonDetailViewModel
                {
                    Id = x.PersonId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    City = x.City,
                    State = x.State,
                    DateOfBirth = x.DateOfBirth,
                    Accomplishments = x.Accomplishments
                    .Select(item => new PersonDetailViewModel.Item
                    {
                        Name = item.Name,
                        DateOfAccomplishment = item.DateOfAccomplishment
                    })
                })
                .SingleOrDefault();
        }


        public UpdatePersonCommand GetPersonForUpdate(int personId)
        {
            return _context.People
                .Where(x => x.PersonId == personId)
                .Where(x => !x.IsDeleted)
                .Select(x => new UpdatePersonCommand
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    City = x.City,
                    State = x.State,
                    DateOfBirth = x.DateOfBirth,
                })
                .SingleOrDefault();
        }

        /// <summary>
        /// Create a new person
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>The id of the new person</returns>
        public int CreatePerson(CreatePersonCommand cmd)
        {
            var person = cmd.ToPerson();
            _context.Add(person);
            _context.SaveChanges();
            return person.PersonId;
        }

        //Assignment 11.1
        public int CreateError(CreateErrorCommand cmd)
        {
            var error = cmd.ToError();
            _context.Add(error);
            _context.SaveChanges();
            return error.ErrorId;
        }
        //--

        /// <summary>
        /// Updates an existing person
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>The id of the new person</returns>
        public void UpdatePerson(UpdatePersonCommand cmd)
        {
            var person = _context.People.Find(cmd.Id);
            if (person == null) { throw new Exception("Unable to find the person"); }
            if (person.IsDeleted) { throw new Exception("Unable to update a deleted person"); }

            cmd.UpdateRecipe(person);
            _context.SaveChanges();
        }

        /// <summary>
        /// Marks an existing person as deleted
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns>The id of the new person</returns>
        public void DeletePerson(int personId)
        {
            var person = _context.People.Find(personId);
            if (person.IsDeleted) { throw new Exception("Unable to delete a deleted person"); }

            person.IsDeleted = true;
            _context.SaveChanges();
        }

        //for Assignment 11.1
        public bool DoesPersonExist(int id)
        {
            return _context.People
                .Where(r => !r.IsDeleted)
                .Where(r => r.PersonId == id)
                .Any();
        }
    }
}
