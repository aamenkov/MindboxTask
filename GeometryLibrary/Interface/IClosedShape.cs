using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Interfaces
{
    /// <summary>
    /// Интерфейс для закрытых пространств
    /// </summary>
    public interface IClosedShape
    {
        /// <summary>
        /// Метод для возврата значения площади фигуры
        /// </summary>
        /// <returns></returns>
        public double GetArea();
    }
}
