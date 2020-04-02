using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6._1.Controllers
{
    public class AssignmentsController : Controller
    {
        private List<Models.Student> students = new List<Models.Student>()
        {
            new Models.Student{ FirstName="Sam", LastName="Lee", Grade=12 },
            new Models.Student{ FirstName="Claudia", LastName="Guan", Grade=11 },
            new Models.Student{ FirstName="Raj", LastName="Bete", Grade=10 },
            new Models.Student{ FirstName="Sam", LastName="Wu", Grade=12 }
        };

        public IActionResult Assignment6_1(int AccessLevel)
        {
            ViewBag.AccessLevel = AccessLevel;
            return View(students);
        }

        public IActionResult Assignment7_1()
        {
            return View();
        }

        public IActionResult Create(AssignmentPerson p)
        {
            return View(p);
        }
    }
}