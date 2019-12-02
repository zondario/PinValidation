using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PINValidation.Contracts.Validation;
using PINValidation.Models;

namespace PINValidation.Controllers
{
    public class PinFormController : Controller
    {
        private readonly IPinValidator _pinValidator;
        public PinFormController(IPinValidator pinValidator)
        {
            this._pinValidator = pinValidator;
        }
        public IActionResult PinForm()
        {
            return View(new PinFormViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PinForm(PinFormViewModel pinFormViewModel)
        {
            if(ModelState.IsValid && this._pinValidator.IsValid(pinFormViewModel.Pin))
            {
                pinFormViewModel = new PinFormViewModel();
                pinFormViewModel.Message = "The PIN you entered is valid!";
            }
            else
            {
                pinFormViewModel.Message = "The PIN you entered is NOT valid";
            }
            return View(pinFormViewModel);
        }
    }
}
