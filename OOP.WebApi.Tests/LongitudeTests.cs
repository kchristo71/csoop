using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OOP.Domain.Type;

namespace OOP.WebApi.Tests
{
    public class LongitudeTests
    {
        [Test]
        public void NegativeValueFails()
        {
            // arrange
            var value = -1;

            // act/assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Longitude(value));
        }
        [Test]
        public void Over360ValueFails()
        {
            // arrange
            var value = 361;
            var message = $"{value} is not a valid {typeof(Longitude).Name}";

            // act/assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Longitude(value), message);
        }
        [Test]
        public void ValidValueSucceeds()
        {
            // arrange
            var value = 1;

            // act
            var longitude = new Longitude(value);

            // assert
            Assert.IsNotNull(longitude);
            Assert.AreEqual(value, longitude.Value);
        }
    }
}
