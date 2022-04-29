using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Model
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IClosedShape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна 0");
            }
            if (firstSide + secondSide <= thirdSide || secondSide + thirdSide <= firstSide || firstSide + thirdSide <= secondSide)
            {
                throw new ArgumentException("Фигура не может являться треугольником");
            }
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        /// <summary>
        /// Проверка треугольника на прямоугольный по теореме Пифагора
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return _firstSide == Math.Sqrt(Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2))
                   || _secondSide == Math.Sqrt(Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2))
                   || _thirdSide == Math.Sqrt(Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2));
        }

        /// <summary>
        /// Метод расчета площади треугольника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var p = (_firstSide + _secondSide + _thirdSide) / 2; 
            return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }
    }
}
