﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GonzStore.Areas.Admin.Controllers
{
    public class DieuKhoangdichvusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
