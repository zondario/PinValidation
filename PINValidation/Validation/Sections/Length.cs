using PINValidation.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Validation.Sections
{
    public class Length : IPinSectionValidator
    {
        public Length(int priority)
        {
            this.Priority = priority;
        }

        public int Priority { get; private set; }

        public bool IsValid(string pin)
        {
            return pin != null && (pin.Length == 10);
        }
    }
}
