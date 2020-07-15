using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс треугольник.
    /// </summary>
    public class Triangle : Figures
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="param">Стороны фигруы.</param>
        public Triangle(string[] param)
            : base(param)
        {

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="points">Точки фигуры.</param>
        public Triangle(List<Point> points)
            : base(points)
        {

        }

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double CalculatArea()
        {
            double perimeter = 0;

            if (Points != null)
            {
                double[] sides = new double[3];

                for (int i = 0; i < Points.Count - 1; i++)
                {
                    sides[i] = Math.Sqrt(Math.Pow(Points[i + 1].X - Points[i].X, 2) + Math.Pow(Points[i + 1].Y - Points[i].Y, 2));
                }
                sides[2] = Math.Sqrt(Math.Pow(Points[Points.Count - 1].X - Points[0].X, 2) + Math.Pow(Points[Points.Count - 1].Y - Points[0].Y, 2));

                for (int i = 0; i < sides.Length; i++)
                {
                    perimeter += sides[i];
                }

                perimeter /= 2;

                Area += Math.Sqrt(perimeter * ((perimeter - sides[0]) * (perimeter - sides[1]) * (perimeter - sides[2])));
            }
            else
            {
                for (int i = 0; i < Sides.Count; i++)
                {
                    perimeter += Sides[i];
                }
                perimeter /= 2;

                Area = Math.Sqrt(perimeter * ((perimeter - Sides[0]) * (perimeter - Sides[1]) * (perimeter - Sides[2])));
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
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    Perimeter += Math.Sqrt(Math.Pow(Points[i + 1].X - Points[i].X, 2) + Math.Pow(Points[i + 1].Y - Points[i].Y, 2));
                }
                Perimeter += Math.Sqrt(Math.Pow(Points[Points.Count - 1].X - Points[0].X, 2) + Math.Pow(Points[Points.Count - 1].Y - Points[0].Y, 2));
            }
            else
            {
                for (int i = 0; i < Sides.Count; i++)
                {
                    Perimeter += Sides[i];
                }
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
