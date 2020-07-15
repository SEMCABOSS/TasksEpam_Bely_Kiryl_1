using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс круг.
    /// </summary>
    public class Сircle : Figures
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="param">Стороны фигруы.</param>
        public Сircle(string[] param)
        : base(param)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="points">Точки фигуры.</param>
        public Сircle(List<Point> points)
        : base(points)
        {

        }

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double CalculatArea()
        {
            if (Points != null)
            {
                Area += Math.PI * Math.Pow(Math.Sqrt(Math.Pow(Points[1].X - Points[0].X, 2) + Math.Pow(Points[1].Y - Points[0].Y, 2)), 2);
            }
            else
            {
                Area += Math.PI * Math.Pow(Sides[0], 2);
            }

            return Area;
        }


        /// <summary>
        /// Вычисление периметра фигуры.
        /// </summary>
        /// <returns>Периметр.</returns>
        public override double CalculatePerimeter()
        {
            if (Points != null)
            {
                Perimeter += 2 * Math.PI * Math.Sqrt(Math.Pow(Points[1].X - Points[0].X, 2) + Math.Pow(Points[1].Y - Points[0].Y, 2));
            }
            else
            {
                Perimeter += 2 * Math.PI * Sides[0];
            }

            return Perimeter;
        }


        /// <summary>
        /// Equals.
        /// </summary>
        /// <param name="obj">Проверяемый объект.</param>
        /// <returns>True or false.</returns>
        public override bool Equals(object obj)
        {
            if ((Figures)obj == null)
                return false;

            if (this.GetType() != obj.GetType())
                return false;

            if (((Figures)obj).Points != null && this.Points != null)
            {

                for (int i = 0; i < ((Figures)obj).Points.Count; i++)
                {
                    if (this.Points[i].X != ((Figures)obj).Points[i].X || this.Points[i].Y != ((Figures)obj).Points[i].Y)
                    {
                        return false;
                    }

                }

                return true;
            }


            if (((Figures)obj).Sides != null && this.Sides != null)
            {
                for (int i = 0; i < ((Figures)obj).Sides.Count; i++)
                {
                    if (this.Sides[i] != ((Figures)obj).Sides[i])
                    {
                        return false;
                    }

                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// HashCode
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            int hashCode = -1035347923;
            hashCode = hashCode * -1521134295 + Area.GetHashCode();
            hashCode = hashCode * -1521134295 + Perimeter.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(Sides);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Point>>.Default.GetHashCode(Points);
            return hashCode;
        }
    }
}
