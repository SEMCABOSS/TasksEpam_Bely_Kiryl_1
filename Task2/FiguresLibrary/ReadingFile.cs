using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс для чтения файла.
    /// </summary>
    public class ReadingFile
    {
        /// <summary>
        /// Путь.
        /// </summary>
        readonly String Patch;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="patch">Путь.</param>
        public ReadingFile(string patch)
        {
            Patch = patch;
        }

        /// <summary>
        /// Чтение файла.
        /// </summary>
        /// <returns>Массив данных.</returns>
        public string[] ReadFile()
        {
            string[] lines = File.ReadAllLines(Patch);
            return lines;
        }
    }
}
