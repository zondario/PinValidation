using PINValidation.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Validation.Sections
{
    public class ContentIsDigits : IPinSectionValidator
    {
        public ContentIsDigits(int priority)
        {
            this.Priority = priority;
        }

        public int Priority { get; private set; }

        public bool IsValid(string pin)
        {
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
