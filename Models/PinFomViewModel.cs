using System;
using System.ComponentModel;

namespace PINValidation.Models
{
    public class PinFormViewModel
    {
        [DisplayName("PIN")]
        public string Pin { get; set; } = "";

        public string Message { get; set; } = "";
    }
}
