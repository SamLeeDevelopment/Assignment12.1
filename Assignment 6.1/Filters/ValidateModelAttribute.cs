using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Assignment_6._1.Filters
{
    public class ValidateModel : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
                context.Result = new RedirectToRouteResult("Create", new CreateErrorCommand(400, "The person could not be formatted correctly", DateTime.Now));
            }
        }
    }
}
