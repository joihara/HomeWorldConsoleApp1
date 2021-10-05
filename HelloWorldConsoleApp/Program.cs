// Импорт сторонних пространств имён
using System;

/// <summary>
/// Пространство имён
/// Основная библиотека
/// </summary>
namespace HelloWorldConsoleApp
{

    class Program
    {
        /// <summary>
        /// Основной метод который вызываеться в первую очередь при запуске программы
        /// </summary>
        /// <param name="args">Параметры с которыми запущена программа</param>
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Hello World!");  // Напечатать строку и перенести курсор на новую строку
            Console.ReadKey();                  // Ожидание нажатия любой клавиши
            //Задание 2
            Console.Write("Hello ");            // Печатает строку без переноса курсора на новую строку
            Console.Write("World ");            // продолжает печать в строке без переноса курсора
            Console.Write("!!!");               // заканчивает печать в строке 
            Console.ReadLine();                 // Ожидание нажатия кнопки Enter для завершения программы
        }
    }
}
