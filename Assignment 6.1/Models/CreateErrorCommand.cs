using Assignment_6._1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Models
{
    public class CreateErrorCommand
    {
        public int HttpStatusCode { get; set; }
        public DateTime TimeOfError { get; set; }
        public string ExceptionMessage { get; set; }

        public CreateErrorCommand(int code, string message, DateTime time)
        {
            this.HttpStatusCode = code;
            this.ExceptionMessage = message;
            this.TimeOfError = time;
        }

        public Error ToError()
        {
            return new Error
            {
                HttpStatusCode = HttpStatusCode,
                TimeOfError= TimeOfError,
                ExceptionMessage = ExceptionMessage,
            };
        }
    }
}
