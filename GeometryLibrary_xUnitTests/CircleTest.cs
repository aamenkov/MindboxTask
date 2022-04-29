using System;
using Xunit;
using GeometryLibrary.Model;

namespace GeometryLibrary_xUnitTests
{
    public class CircleTest
    {
        /// <summary>
        /// Тест подсчета площади
        /// </summary>
        [Fact]
        public void AreaTest()
        {
            Assert.Equal(Math.PI, new Circle(1).GetArea());
            Assert.Equal(Math.PI * Math.Pow(5, 2), new Circle(5).GetArea());
            Assert.Equal(78.53982, Math.Round(new Circle(5).GetArea(), 5));
            Assert.Equal(Math.PI * Math.Pow(412, 2), new Circle(412).GetArea());
            Assert.Equal(533266.50339, Math.Round(new Circle(412).GetArea(), 5));
        }

        /// <summary>
        /// Тест выбрасывания исключений
        /// </summary>
        [Fact]
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).GetArea());
            Assert.Throws<ArgumentException>(() => new Circle(-10));
            Assert.Throws<ArgumentException>(() => new Circle(-100).GetArea());
        }
    }
}
