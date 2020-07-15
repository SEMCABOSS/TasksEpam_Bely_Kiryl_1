using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Фабрика.
    /// </summary>
    abstract class CreateFigures
    {
        /// <summary>
        /// Фабричный метод.
        /// </summary>
        /// <param name="param">Стороны.</param>
        /// <returns>Figures.</returns>
        abstract public Figures Create(string[] param);

        /// <summary>
        /// Фабричный метод.
        /// </summary>
        /// <param name="points">Точки.</param>
        /// <returns>Figures.</returns>
        abstract public Figures Create(List<Point> points);
    }
}
