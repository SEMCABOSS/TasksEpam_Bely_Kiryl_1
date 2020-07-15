using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс для создание экземпляра круга.
    /// </summary>
    class CreateСircle : CreateFigures
    {
        /// <summary>
        /// Создание экземпляра круга.
        /// </summary>
        /// <param name="param">Стороны.</param>
        /// <returns>new Circle(param).</returns>
        public override Figures Create(string[] param)
        {
            return new Сircle(param);
        }

        /// <summary>
        /// Создание экземпляра круга.
        /// </summary>
        /// <param name="points">Точки.</param>
        /// <returns>new Circle(points).</returns>
        public override Figures Create(List<Point> points)
        {
            return new Сircle(points);
        }

    }
}
