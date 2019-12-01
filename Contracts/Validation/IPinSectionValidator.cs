using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Contracts.Validation
{
    public interface IPinSectionValidator
    {
        int Priority { get; }
        public bool IsValid(string pin);
    }
}
