using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PINValidation.Tests.Validation.Sections
{
    public class LengthTests
    {
        [Fact]
        public void TestValidLength()
        {
            Length lengthValidator = new Length(0);
            Assert.True(lengthValidator.IsValid("1234567890"));
        }

        [Fact]
        public void TestGreaterLength()
        {
            Length lengthValidator = new Length(0);
            Assert.False(lengthValidator.IsValid("12345678901"));
        }

        [Fact]
        public void TestSmallerLength()
        {
            Length lengthValidator = new Length(0);
            Assert.False(lengthValidator.IsValid("123456789"));
        }

        [Fact]
        public void TestNull()
        {
            Length lengthValidator = new Length(0);
            Assert.False(lengthValidator.IsValid(null));
        }
    }
}
