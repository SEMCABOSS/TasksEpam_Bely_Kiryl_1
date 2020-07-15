using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс для создание экземпляра параллелограмма.
    /// </summary>
    class CreateParallelogram : CreateFigures
    {
        /// <summary>
        /// Создание экземпляра параллелограмма.
        /// </summary>
        /// <param name="param">Стороны.</param>
        /// <returns>new Parallelogram(param).</returns>
        public override Figures Create(string[] param)
        {
            return new Parallelogram(param);
        }

        /// <summary>
        /// Создание экземпляра параллелограмма.
        /// </summary>
        /// <param name="points">Точки.</param>
        /// <returns>new Parallelogram(points).</returns>
        public override Figures Create(List<Point> points)
        {
            return new Parallelogram(points);
        }

    }
}
