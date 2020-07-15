using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclideanAlgorithmLibrary;

namespace UnitTestEuclideanAlgorithm
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Экземпляр класса EuclideanAlgorithm.
        /// </summary>
        EuclideanAlgorithm algorithm = new EuclideanAlgorithm();

        /// <summary>
        /// Тест на проверку метода GCD с 2 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm1()
        {   
            Assert.AreEqual(8, algorithm.GCD(12344, 2312));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 2 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm2()
        {
            Assert.AreEqual(1, algorithm.GCD(322, 3));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 2 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm3()
        {
            Assert.AreEqual(500, algorithm.GCD(1000, 500));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 3 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm4()
        {
            Assert.AreEqual(2, algorithm.GCD(322, 42122, 324));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 4 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm5()
        {
            Assert.AreEqual(10, algorithm.GCD(150, 200, 10, 150));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 5 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm6()
        {
            Assert.AreEqual(50, algorithm.GCD(150, 200, 150, 300, 400));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 5 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm7()
        {
            Assert.AreEqual(4, algorithm.GCD(152, 500, 1000, 300, 404));
        }

        /// <summary>
        /// Тест на проверку метода GCD с 5 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodEuclideanAlgorithm8()
        {
            Assert.AreNotEqual(5, algorithm.GCD(152, 500, 1000, 300, 404));
        }

        /// <summary>
        /// Тест на проверку метода BinaryGCD с 3 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodBinaryEuclideanAlgorithm9()
        {
            TimeSpan time;
            Assert.AreEqual(5, algorithm.BinaryGCD(4000, 255, out time));
        }
        /// <summary>
        /// Тест на проверку метода BinaryGCD с 3 параметрами.
        /// </summary>
        [TestMethod]
        public void TestMethodBinaryEuclideanAlgorithm10()
        {
            TimeSpan time;
            Assert.AreEqual(5, algorithm.GCD(15, 5, out time));
        }

        /// <summary>
        /// Тест на проверку метода GetDataForHistogram.
        /// </summary>
        [TestMethod]
        public void TestMethodGetDataForHistogram()
        {
            Assert.IsNotNull(algorithm.GetDataForHistogram().Item1);
            Assert.IsNotNull(algorithm.GetDataForHistogram().Item2);
        }

    }
}
