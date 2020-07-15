using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс фигур.
    /// </summary>
    public abstract class Figures
    {
        /// <summary>
        /// Площадь.
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Периметр.
        /// </summary>
        public double Perimeter { get; set; }
        /// <summary>
        /// Лист сторон.
        /// </summary>
        public List<Int32> Sides { get; set; }
        /// <summary>
        /// Лист точек.
        /// </summary>
        public List<Point> Points { get; set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="param">Стороны фигруы.</param>
        public Figures(string[] param)
        {
            Sides = new List<int>();

            for (int i = 1; i < param.Length; i++)
            {
                Sides.Add(Int32.Parse(param[i]));
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="points">Точки фигуры.</param>
        public Figures(List<Point> points)
        {
            Points = new List<Point>();

            for (int i = 0; i < points.Count; i++)
            {
                Points.Add(points[i]);
            }
        }

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь.</returns>
        public abstract double CalculatArea();

        /// <summary>
        /// Вычисление периметра фигуры.
        /// </summary>
        /// <returns>Периметр.</returns>
        public abstract double CalculatePerimeter();


        /// <summary>
        /// Нахождения одинаковых фигур с данной.
        /// </summary>
        /// <param name="figures">Массив фигур.</param>
        /// <param name="other">Данная фигура.</param>
        /// <returns>List<Figures> sortedFigures</returns>
        public static List<Figures> GetSimilarFigures(List<Figures> figures, Figures other)
        {
            List<Figures> sortedFigures = new List<Figures>();

            foreach (Figures figure in figures)
            {
                if (other.Equals(figure))
                {
                    sortedFigures.Add(figure);
                }
            }

            return sortedFigures;
        }

        /// <summary>
        /// Создание листа фигур.
        /// </summary>
        /// <param name="figureData">Массив данных фигур.</param>
        /// <returns>Массив фигур.</returns>
        public static List<Figures> CreateFigures(string[] figureData)
        {
            CreateFigures creator = null;
            List<Figures> figures = new List<Figures>();
            List<Point> points = new List<Point>();
            string checkFigure;
            Regex regex = new Regex(@"[,]");
            bool flag;

            for (int i = 0; i < figureData.Length; i++)
            {
                string[] param;

                if (regex.IsMatch(figureData[i]))
                {
                    param = figureData[i].Split(' ', ',');

                    for (int j = 1; j < param.Length - 1; j += 2)
                    {
                        points.Add(new Point(Int32.Parse(param[j]), Int32.Parse(param[j + 1])));
                    }

                    flag = true;
                }
                else
                {
                    param = figureData[i].Split(' ');
                    flag = false;
                }

                checkFigure = param[0];

                switch (checkFigure)
                {
                    case "Triangle":
                        creator = new CreateTriangle();
                        break;

                    case "Square":
                        creator = new CreateSquare();
                        break;

                    case "Circle":
                        creator = new CreateСircle();
                        break;

                    case "Parallelogram":
                        creator = new CreateParallelogram();
                        break;
                }

                if (creator != null)
                {
                    if (flag)
                    {
                        figures.Add(creator.Create(points));
                    }
                    else
                    {
                        figures.Add(creator.Create(param));
                    }

                }

                points.Clear();
            }

            return figures;
        }

        /// <summary>
        /// Equals.
        /// </summary>
        /// <param name="obj">Проверяемый объект.</param>
        /// <returns>True or false.</returns>
        public override bool Equals(object obj)
        {
            return obj is Figures figures &&
                   Area == figures.Area &&
                   Perimeter == figures.Perimeter &&
                   EqualityComparer<List<int>>.Default.Equals(Sides, figures.Sides) &&
                   EqualityComparer<List<Point>>.Default.Equals(Points, figures.Points);
        }

        /// <summary>
        /// GetHashCode
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
