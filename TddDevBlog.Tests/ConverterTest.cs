using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TddDevBlog.API.Business;

namespace TddDevBlog.Tests
{
    [TestFixture]
    class ConverterTest
    {
        private readonly double _celsius;
        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void Teardown()
        {

        }

        [Test]
        public void CelsiusToFarhenheit_ZeroCelsius_Result32()
        {
            //arrange
            var celsius = 0;
            var converter = new Converter();
            var expected = 32; 

            //act
            var result = converter.ConvertCelsiusToFarhenheit(celsius);
            //assert
            Assert.That(result, Is.EqualTo(expected)); 
        }
    }
}
