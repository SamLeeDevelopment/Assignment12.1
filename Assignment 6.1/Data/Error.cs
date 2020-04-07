using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6._1.Data
{
    public class Error
    {
        public int ErrorId { get; set; }
        public int HttpStatusCode { get; set; }
        public DateTime TimeOfError { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
