﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWeb.Entities
{
    public class DataResult<T> : BaseResult
    {
        public T Data { get; set; }
    }
}