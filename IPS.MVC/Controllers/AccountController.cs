﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPS.MVC.Controllers {
    public class AccountController : Controller {
        public IActionResult Index() {

            return View();
        }
    }
}
