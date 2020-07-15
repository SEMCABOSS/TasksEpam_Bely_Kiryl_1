using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Структура точка.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// X.
        /// </summary>
        public Int32 X { get; set; }

        /// <summary>
        /// Y.
        /// </summary>
        public Int32 Y { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="x">X.</param>
        /// <param name="y">Y.</param>
        public Point(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }
    }
}
