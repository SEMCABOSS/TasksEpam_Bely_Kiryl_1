using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EuclideanAlgorithmLibrary
{
    /// <summary>
    /// Ссылочный тип для реализации алгоритма Евклида.
    /// </summary>
    public class EuclideanAlgorithm
    {
        /// <summary>
        /// Экземпляр класса Stopwatch.
        /// </summary>
        private Stopwatch watch = new Stopwatch();


        /// <summary>
        /// Метод для нахождения НОД 2х чисел.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число.</param>
        /// <returns>НОД 2х чисел.</returns>
        public Int32 GCD(Int32 number1, Int32 number2)
        {
            while ((number1 != 0) && (number2 != 0))
            {
                if (number1 > number2)
                    number1 -= number2;
                else
                    number2 -= number1;
            }

            return Math.Max(number1, number2);
        }

        /// <summary>
        /// Метод для нахождения НОД 3х чисел.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число.</param>
        /// <param name="number3">Третье число.</param>
        /// <returns>НОД 3х чисел.</returns>
        public Int32 GCD(Int32 number1, Int32 number2, Int32 number3)
        {
            return GCD(GCD(number1, number2), number3);
        }

        /// <summary>
        /// Метод для нахождения НОД 4х чисел.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число.</param>
        /// <param name="number3">Третье число.</param>
        /// <param name="number4">Четвертое число.</param>
        /// <returns>НОД 4х чисел.</returns>
        public Int32 GCD(Int32 number1, Int32 number2, Int32 number3, Int32 number4)
        {
            return GCD(GCD(number1, number2), GCD(number3, number4));
        }

        /// <summary>
        /// Метод для нахождения НОД 5х чисел.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число</param>
        /// <param name="number3">Третье число.</param>
        /// <param name="number4">Четвертое число.</param>
        /// <param name="number5">Пятое число.</param>
        /// <returns>НОД 5х чисел.</returns>
        public Int32 GCD(Int32 number1, Int32 number2, Int32 number3, Int32 number4, Int32 number5)
        {
            return GCD(GCD(GCD(number1, number2), GCD(number3, number4)), number5);
        }

        /// <summary>
        /// Метод для нахождения НОД при помощи бинарного алгоритма.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число.</param>
        /// <param name="time">Время работы.</param>
        /// <returns>НОД 2х чисел.</returns>
        public Int32 BinaryGCD(Int32 number1, Int32 number2, out TimeSpan time)
        {

            watch.Start();
            
            if (number1 == 0)
            {
                watch.Stop();
                time = watch.Elapsed;
                return number2;
            }
                                      
            if (number2 == 0)
            {
                watch.Stop();
                time = watch.Elapsed;
                return number1;
            }
                              
            if (number1 == number2)
            {
                watch.Stop();
                time = watch.Elapsed;
                return number1;
            }
                                     
            if (number1 == 1 || number2 == 1)
            {
                watch.Stop();
                time = watch.Elapsed;
                return 1;
            }          
            
            if ((number1 & 1) == 0)                        
                return ((number2 & 1) == 0)
                    ? BinaryGCD(number1 >> 1, number2 >> 1,out time) << 1       
                    : BinaryGCD(number1 >> 1, number2, out time);                
            else                                  
                return ((number2 & 1) == 0)
                    ? BinaryGCD(number1, number2 >> 1, out time)                 
                    : BinaryGCD(number2, number1 > number2 ? number1 - number2 : number2 - number1, out time); 
        }

        /// <summary>
        /// Метод для нахождения НОД 2х чисел.
        /// </summary>
        /// <param name="number1">Первое число.</param>
        /// <param name="number2">Второе число.</param>
        /// <param name="time">Время работы.</param>
        /// <returns>НОД 2х чисел.</returns>
        public Int32 GCD(Int32 number1, Int32 number2, out TimeSpan time)
        {
            if(watch.ElapsedTicks != 0)
            {
                watch.Restart();
            }    
            else
            {
                watch.Start();
            }    

            while ((number1 != 0) && (number2 != 0))
            {
                if (number1 > number2)
                    number1 -= number2;
                else
                    number2 -= number1;
            }

            watch.Stop();
            time = watch.Elapsed;
    
            return Math.Max(number1, number2);
        }

        /// <summary>
        /// Подготовка данных для построения гистограммы.
        /// </summary>
        /// <returns>TimeSpan timeGCD, TimeSpan timeBinaryGCD</returns>
        public (TimeSpan, TimeSpan) GetDataForHistogram()
        {
            TimeSpan timeGCD, timeBinaryGCD;

            BinaryGCD(555000042, 5, out timeBinaryGCD);
            GCD(10000, 5, out timeGCD);

            return (timeGCD, timeBinaryGCD);
        }
    }
}
