using System;
using GeometryLibrary.Model;
using Xunit;

namespace GeometryLibrary_xUnitTests
{
    public class TriangleTest
    {

        /// <summary>
        /// Тест подсчета площади
        /// </summary>
        [Fact]
        public void AreaTest()
        {
            Assert.Equal(6, new Triangle(3, 4, 5).GetArea());
            Assert.Equal(0, new Triangle(1, 1, 2).GetArea());

            Assert.Equal(19.81003533565753, new Triangle(10, 5, 8).GetArea());
            Assert.Equal(1082.5317547305483, new Triangle(50, 50, 50).GetArea());
            Assert.Equal(0.4330127018922193, new Triangle(1, 1, 1).GetArea());

            Assert.Equal(true, new Triangle(4, 3, 5).IsRight());
            Assert.Equal(false, new Triangle(1, 2, 3).IsRight());
        }

        /// <summary>
        /// Тест выбрасывания исключений
        /// </summary>
        [Fact]
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -2, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -2, 3).GetArea());
        }
    }
}
