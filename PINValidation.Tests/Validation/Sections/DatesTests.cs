using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PINValidation.Tests.Validation.Sections
{
    public class DatesTests
    {
        [Fact]
        public void TestValidDatesNormal()
        {
            Dates datesValidator = new Dates(0);

            string pin = "8802139012";
            
            Assert.True(datesValidator.IsValid(pin));
        }

        [Fact]
        public void TestInvalidDatesNormal()
        {
            Dates datesValidator = new Dates(0);

            string pin = "88132439012";

            Assert.False(datesValidator.IsValid(pin));
        }

        [Fact]
        public void TestInvalidMonth()
        {
            Dates datesValidator = new Dates(0);

            string pin = "9613139012";

            Assert.False(datesValidator.IsValid(pin));
        }

        [Fact]
        public void TestInvalidDate()
        {
            Dates datesValidator = new Dates(0);

            string pin = "9603329012";

            Assert.False(datesValidator.IsValid(pin));
        }

        [Fact]
        public void TestValidDatesBefore1900()
        {
            Dates datesValidator = new Dates(0);

            string pin = "9621219012";

            Assert.True(datesValidator.IsValid(pin));
        }

        [Fact]
        public void TestValidDatesAfter2000()
        {
            Dates datesValidator = new Dates(0);

            string pin = "0141219012";

            Assert.True(datesValidator.IsValid(pin));
        }
    }
}
