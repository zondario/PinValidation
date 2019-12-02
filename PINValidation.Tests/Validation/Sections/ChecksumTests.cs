using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PINValidation.Tests.Validation.Sections
{
    public class ChecksumTests
    {
        [Fact]
        public void TestValid()
        {
            Checksum checksumValidator = new Checksum(0);
            Assert.True(checksumValidator.IsValid("5402087615"));
        }

        [Fact]
        public void TestInvalid()
        {
            Checksum checksumValidator = new Checksum(0);
            Assert.False(checksumValidator.IsValid("5402087614"));
        }
    }
}
