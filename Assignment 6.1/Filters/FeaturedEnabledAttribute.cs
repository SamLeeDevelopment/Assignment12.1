using Assignment_6._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Filters
{
    public class FeatureEnabledAttribute : Attribute, IResourceFilter
    {
        public bool IsEnabled { get; set; }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!IsEnabled)
            {
                context.Result = new RedirectToRouteResult("Create", new CreateErrorCommand(400, "The page you were looking for could not be found", DateTime.Now));
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context) { }
    }
}
