using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PINValidation.Tests.Validation
{
    public class PinValidatorTests
    {
        private PinValidator CreatePinValidator()
        {
            IList<IPinSectionValidator> validators = new List<IPinSectionValidator>();
            validators.Add(new Length(0));
            validators.Add(new ContentIsDigits(1));
            validators.Add(new Dates(2));
            validators.Add(new Checksum(3));
            return new PinValidator(validators);
        }
        [Fact]
        public void TestValidPin()
        {
            Assert.True(this.CreatePinValidator().IsValid("6101047500"));
        }
        [Fact]
        public void TestInvalidPin()
        {
            Assert.False(this.CreatePinValidator().IsValid("6201047500"));
        }
    }
}
