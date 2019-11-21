using System;
using NUnit.Framework;
using OOP.Domain.Type;

namespace OOP.WebApi.Tests
{
    public class LatitudeTests
    {
        [TestCase(-91)]
        [TestCase(91)]
        public void CastInvalidValueFails(double value)
        {
            // act/assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var latitude = (Latitude)value;
            });
        }

        [TestCase(-91)]
        [TestCase(91)]
        public void CreateWithInvalidValueFails(double value)
        {
            // act/assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var latitude = new Latitude(value);
            });
        }

        [TestCase(1)]
        [TestCase(90)]
        [TestCase(-90)]
        public void ValidValueSucceeds(double value)
        {
            // act
            var longitude = new Latitude(value);

            // assert
            Assert.IsNotNull(longitude);
            Assert.AreEqual(value, longitude.Value);
        }


        [TestCase(1)]
        [TestCase(90)]
        [TestCase(-90)]
        public void CastingValidDoubleSucceeds(double value)
        {
            // act
            var longitude = (Latitude)value;

            // assert
            Assert.IsNotNull(longitude);
            Assert.AreEqual(value, longitude.Value);
        }

        [TestCase(1)]
        [TestCase(90)]
        [TestCase(-90)]
        [TestCase(1.1)]
        [TestCase(89.45)]
        [TestCase(-89.123)]
        public void CastToDoubleSucceeds(double value)
        {
            // arrange
            var latitude = new Latitude(value);

            // act
            var doubleValue = (double) latitude;

            // assert
            Assert.AreEqual(value, doubleValue);
        }
    }
}
