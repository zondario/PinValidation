using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Contracts.Validation
{
    public interface IPinValidator
    {
        public bool IsValid(string pin);
    }
}
