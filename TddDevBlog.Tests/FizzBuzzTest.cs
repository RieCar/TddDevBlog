using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TddDevBlog.API.Business;

namespace TddDevBlog.Tests
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(3, "Fizz")]
        [TestCase(1, " ")]
        public void Should_ReturnMatchingString_When_Modulus0(int number, string expected)
        {
            //arrange
            var _checker = new FizzBuzz();

            //act
            var result = _checker.Ask(number);

            //Assert
            Assert.That(result, Is.EqualTo(expected));

        }

    }
}
