using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string message)
        {
            Success = success;
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get ; }
    }
}
