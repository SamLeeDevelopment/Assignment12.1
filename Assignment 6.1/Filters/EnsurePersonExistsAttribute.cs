using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Filters
{
    public class EnsurePersonExistsAttribute : TypeFilterAttribute
    {
        public EnsurePersonExistsAttribute() : base(typeof(EnsurePersonExistsFilter)) { }

        public class EnsurePersonExistsFilter : IActionFilter
        {
            private readonly PersonService _service;
            public EnsurePersonExistsFilter(PersonService service)
            {
                _service = service;
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                var recipeId = (int)context.ActionArguments["id"];
                if (!_service.DoesPersonExist(recipeId))
                {
                    context.Result = new RedirectToRouteResult("Create", new CreateErrorCommand(404, "The person you requested could not be found", DateTime.Now));
                }
            }

            public void OnActionExecuted(ActionExecutedContext context) { }
        }
    }
}
