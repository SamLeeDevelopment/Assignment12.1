using Assignment_6._1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Models
{
    public class ErrorSummaryViewModel
    {
        public int Id { get; set; }
        public int HttpStatusCode { get; set; }
        public DateTime TimeOfError { get; set; }
        public string ExceptionMessage { get; set; }

        public static ErrorSummaryViewModel FromError(Error error)
        {
            return new ErrorSummaryViewModel
            {
                Id = error.ErrorId,
                HttpStatusCode = error.HttpStatusCode,
                ExceptionMessage = error.ExceptionMessage,
                TimeOfError = error.TimeOfError,
            };
        }
    }
}
