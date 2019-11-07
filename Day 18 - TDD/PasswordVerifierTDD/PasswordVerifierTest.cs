using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PasswordVerifierTDD
{
    public class PasswordVerifierTest
    {
        string validPassword = "Hello!1234";
        string invalidPassword = "hello";

        [Fact]
        public void TestInvalidLength()
        {
            bool actual = PasswordVerifier.VerifyPassword(invalidPassword);
            Assert.False(actual);
        }

        [Fact]
        public void TestValidLength()
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }

        [Fact]
        public void TestInvalidSymbol()
        {
            bool actual = PasswordVerifier.VerifyPassword(invalidPassword);
            Assert.False(actual);
        }

        [Fact]
        public void TestValidSymbol()
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }

        [Fact]
        public void TestInvalidNumber()
        {
            bool actual = PasswordVerifier.VerifyPassword("Hello!World");
            Assert.False(actual);
        }

        [Fact]
        public void TestValidNumber()
        {
            bool actual = PasswordVerifier.VerifyPassword(validPassword);
            Assert.True(actual);
        }
    }
}
