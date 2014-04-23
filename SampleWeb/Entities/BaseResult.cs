using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.Entities
{
    public class BaseResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}