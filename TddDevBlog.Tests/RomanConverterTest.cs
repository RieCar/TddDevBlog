using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TddDevBlog.API.Business;

namespace TddDevBlog.Tests
{
    [TestFixture]
    class RomanConverterTest
    {
        [Test]
        [TestCase(2, "II")]
        [TestCase(6, "VI")]
        public void ParseRomanToInt(int expected, string roman)
        {
            //arrange
            var parser = new RomanNumberConverter();

            // act
            var result = parser.ConvertRomanToInt(roman);

            //assert

            Assert.That(result, Is.EqualTo(expected));
           
        }

    }
}
