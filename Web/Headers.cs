﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class Headers
    {
        [FromHeader]
        public string Autorization { get; set; }

    }
}
