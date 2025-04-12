using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilies.Results
{
    public class Result : IResults
    {
        public Result(bool success, string message) : this(success)
        {
            //this yazdığım için bu aşağıdakini de çağırır.
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
