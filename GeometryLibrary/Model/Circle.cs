using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Interfaces;


namespace GeometryLibrary.Model
{
    /// <summary>
    /// Класс круг
    /// </summary>
    public class Circle : IClosedShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен 0");
            }
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
