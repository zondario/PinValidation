using PINValidation.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Validation.Sections
{
    public class Checksum : IPinSectionValidator
    {
        public Checksum(int priority)
        {
            this.Priority = priority;
        }
        public int Priority { get; private set; }

        public bool IsValid(string pin)
        {
            int[] egnWeights = new int[9] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int checkSum = int.Parse(pin.Substring(9, 1));
            int egnSum = 0;
            for (int i = 0; i < 9; i++)
            {
                egnSum += int.Parse(pin.Substring(i, 1)) * egnWeights[i];
            }
            egnSum %= 11;
            if (egnSum == 10)
            {
                egnSum = 0;
            }
            return checkSum == egnSum;
        }
    }
}
