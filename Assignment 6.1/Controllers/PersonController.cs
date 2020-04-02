using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6._1.Controllers
{
    public class PersonController : Controller
    {
        public PersonService _service;
        public PersonController(PersonService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var models = _service.GetPeople();

            return View(models);
        }

        public IActionResult View(int id)
        {
            var model = _service.GetPersonDetail(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new CreatePersonCommand());
        }

        [HttpPost]
        public IActionResult Create(CreatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var id = _service.CreatePerson(command);
                    return RedirectToAction(nameof(View), new { id = id });
                }
            }
            catch (Exception)
            {
                // TODO: Log error
                // Add a model-level error by using an empty string key
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving the person"
                    );
            }

            return View(command);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.GetPersonForUpdate(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UpdatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.UpdatePerson(command);
                    return RedirectToAction(nameof(View), new { id = command.Id });
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving the person"
                    );
            }

            return View(command);
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            _service.DeletePerson(id);

            return RedirectToAction(nameof(Index));
        }

    }
}