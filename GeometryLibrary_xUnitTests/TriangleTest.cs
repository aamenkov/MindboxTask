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

            Assert.Equal(0.43301, new Triangle(1, 1, 1).GetArea(), 5);
            Assert.Equal(19.810035, new Triangle(10, 5, 8).GetArea(), 5);
            Assert.Equal(1558.84573, new Triangle(60, 60, 60).GetArea(), 5);


            Assert.True(new Triangle(4, 3, 5).IsRight());
            Assert.False(new Triangle(12, 5, 8).IsRight());
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
