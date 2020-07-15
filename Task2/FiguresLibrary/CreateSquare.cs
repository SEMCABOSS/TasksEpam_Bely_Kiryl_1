using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс для создание экземпляра квадрата.
    /// </summary>
    class CreateSquare : CreateFigures
    {
        /// <summary>
        /// Создание экземпляра квадрата.
        /// </summary>
        /// <param name="param">Стороны.</param>
        /// <returns>new Square(param).</returns>
        public override Figures Create(string[] param)
        {
            return new Square(param);
        }

        /// <summary>
        /// Создание экземпляра квадрата.
        /// </summary>
        /// <param name="points">Точки.</param>
        /// <returns>new Square(points).</returns>
        public override Figures Create(List<Point> points)
        {
            return new Square(points);
        }
    }
}
