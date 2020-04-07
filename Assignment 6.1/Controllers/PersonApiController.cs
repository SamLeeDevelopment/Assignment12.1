using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Filters;
using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;

/*
 * Assignment 11.1
 */

namespace Assignment_6._1.Controllers
{
    [ValidateModel, HandleException, FeatureEnabled(IsEnabled = true)]
    public class PersonApiController : Controller
    {
        public PersonService _service;
        public PersonApiController(PersonService service)
        {
            _service = service;
        }

        [Route("PersonApi/Index")]
        public IActionResult Index()
        {
            var models = _service.GetErrors();

            return View(models);
        }

        public IActionResult Create(CreateErrorCommand command)
        {
            var id = _service.CreateError(command);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}"), EnsurePersonExists]
        public IActionResult Get(int id)
        {
            var detail = _service.GetPersonDetail(id);
            return Ok(detail);

        }

        [HttpPost("{id}"), EnsurePersonExists]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            _service.UpdatePerson(command);
            return Ok();
        }
    }
}