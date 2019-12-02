using PINValidation.Contracts.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.Validation.Sections
{
    public class Dates : IPinSectionValidator
    {
        public Dates(int priority)
        {
            this.Priority = priority;
        }

        public int Priority { get; private set; }

        public bool IsValid(string pin)
        {
            string year = pin.Substring(0, 2);
            string month = pin.Substring(2, 2);
            string day = pin.Substring(4, 2);
            string date;
            DateTime dt;
            if (int.Parse(month) > 40)
            {
                month = (int.Parse(month) - 40).ToString();
                date = day + '/' + month + '/' + (int.Parse(year) + 2000);

            }
            else if (int.Parse(month) > 20)
            {
                month = (int.Parse(month) - 20).ToString();
                date = day + '/' + month + '/' + (int.Parse(year) + 1800);
            }
            else
            {

                date = day + '/' + month + '/' + (int.Parse(year) + 1900);
            }

            return DateTime.TryParse(date, out dt);
        }
    }
}
