using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PINValidation.Models;

namespace PINValidation.Controllers
{
    public class PinFormController : Controller
    {

        public IActionResult PinForm()
        {
            return View();
        }
    }
}
