using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestFigures
{
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// Класс для чтение файла.
        /// </summary>
        ReadingFile ReadingFile = new ReadingFile(@"D:\test.txt");

        /// <summary>
        /// Проверка на чтение файла.
        /// </summary>
        [TestMethod]
        public void TestMethodReadFile()
        {
            ReadingFile.ReadFile();
        }

        /// <summary>
        /// Проверка на создания объектов и занесение их в массив.
        /// </summary>
        [TestMethod]
        public void TestMethodCreateFigures()
        {
            List<Figures> figures = new List<Figures>();

            figures = Figures.CreateFigures(ReadingFile.ReadFile());

            int countObj = 11;

            Assert.AreEqual(countObj, figures.Count);
        }

        /// <summary>
        /// Проверка на корректное создания структуры.
        /// </summary>
        [TestMethod]
        public void TestMethodCreatePoint()
        {
            Point point = new Point(10, 20);

            int x = 10;
            int y = 20;

            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }

        /// <summary>
        /// Проверка подсчета площади квадрата.
        /// </summary>
        [TestMethod]
        public void TestMethodSquareArea()
        {
            string[] param = new string[] { "10", "10", "10", "10" };
            Square square = new Square(param);

            Assert.AreEqual(100, square.CalculatArea());
        }

        /// <summary>
        /// Проверка подсчета периметра квадрата.
        /// </summary>
        [TestMethod]
        public void TestMethodSquarePerimeter()
        {
            string[] param = new string[] { "10", "10", "10", "10" };
            Square square = new Square(param);

            Assert.AreEqual(40, square.CalculatePerimeter());
        }

        /// <summary>
        /// Проверка подсчета периметра треугольника.
        /// </summary>
        [TestMethod]
        public void TestMethodTrianglePerimeter()
        {
            string[] param = new string[] { " ", "10", "10", "5" };
            Triangle triangle = new Triangle(param);

            Assert.AreEqual(25, triangle.CalculatePerimeter());
        }

        /// <summary>
        /// Проверка подсчета периметра круга.
        /// </summary>
        [TestMethod]
        public void TestMethodCirclePerimeter()
        {
            List<Point> points = new List<Point>() { new Point(0, 0), new Point(3, 3) };
            Сircle сircle = new Сircle(points);

            Assert.AreEqual(26.657297628950193, сircle.CalculatePerimeter());
        }

        /// <summary>
        /// Проверка подсчета площади круга.
        /// </summary>
        [TestMethod]
        public void TestMethodCircleArea()
        {
            List<Point> points = new List<Point>() { new Point(0, 0), new Point(3, 3) };
            Сircle сircle = new Сircle(points);

            Assert.AreEqual(56.548667764616262, сircle.CalculatArea());
        }

        /// <summary>
        /// Проверка подсчета площади параллелограмма.
        /// </summary>
        [TestMethod]
        public void TestMethodParallelogramArea()
        {
            List<Point> points = new List<Point>() { new Point(0, 0), new Point(3, 3), new Point(10, 3), new Point(7, 0) };
            Parallelogram parallelogram = new Parallelogram(points);

            Assert.AreEqual(21, parallelogram.CalculatArea());
        }

        /// <summary>
        /// Проверка подсчета периметра параллелограмма.
        /// </summary>
        [TestMethod]
        public void TestMethodParallelogramPerimeter()
        {
            List<Point> points = new List<Point>() { new Point(0, 0), new Point(3, 3), new Point(10, 3), new Point(7, 0) };
            Parallelogram parallelogram = new Parallelogram(points);

            Assert.AreEqual(22.485281374238568, parallelogram.CalculatePerimeter());
        }

        /// <summary>
        /// Проверка нахождения в массиве всех фигур, равные данной. 
        /// </summary>
        [TestMethod]
        public void TestMethodSimularFigures()
        {
            List<Figures> figures = new List<Figures>();
            List<Figures> sorteSimularFigures = new List<Figures>();
            string[] param = new string[] { " ", "3", "6", "3", "6" };
            figures = Figures.CreateFigures(ReadingFile.ReadFile());

            foreach (Figures figure in figures)
            {
                if (figure is Parallelogram)
                {
                    sorteSimularFigures = Figures.GetSimilarFigures(figures, new Parallelogram(param));
                }
            }

            Assert.AreEqual(3, sorteSimularFigures.Count);
        }
    }
}
