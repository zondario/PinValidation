using PINValidation.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Validation
{
    public class PinValidator : IPinValidator
    {
        private IList<IPinSectionValidator> _validators;

        public PinValidator(IList<IPinSectionValidator> validators)
        {
            validators = validators.OrderBy(t => t.Priority).ToList();
            this._validators = validators;
        }

        public bool IsValid(string pin)
        {
            foreach (IPinSectionValidator sectionValidator in this._validators)
            {
                if (!sectionValidator.IsValid(pin))
                {
                    return false;
                }
            }
            return true;
        }
    }
}