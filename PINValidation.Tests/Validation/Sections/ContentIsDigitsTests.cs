using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PINValidation.Tests.Validation.Sections
{
    public class ContentIsDigitsTests
    {
        [Fact]
        public void TestValid()
        {
            ContentIsDigits contentIsDigitsValidator = new ContentIsDigits(0);
            Assert.True(contentIsDigitsValidator.IsValid("1234567890"));
        }

        [Fact]
        public void TestInvalid()
        {
            ContentIsDigits contentIsDigitsValidator = new ContentIsDigits(0);
            Assert.False(contentIsDigitsValidator.IsValid("123456780a"));
        }
    }
}
