using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс для создание экземпляра треугольника.
    /// </summary>
    class CreateTriangle : CreateFigures
    {
        /// <summary>
        /// Создание экземпляра треугольника.
        /// </summary>
        /// <param name="param">Стороны.</param>
        /// <returns>new Triangle(param)</returns>
        public override Figures Create(string[] param)
        {
            return new Triangle(param);
        }

        /// <summary>
        /// Создание экземпляра треугольника.
        /// </summary>
        /// <param name="points">Стороны.</param>
        /// <returns>new Triangle(points).</returns>
        public override Figures Create(List<Point> points)
        {
            return new Triangle(points);
        }
    }
}
