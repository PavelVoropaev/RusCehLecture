// Ключевое слово namespace (пространство имён) используется для объявления области, 
// которая содержит набор связанных объектов
namespace Lecture1
{
    using System;

    // Объявление класса ComplexNumber
    class ComplexNumber
    {
        // Объявление публичного поля класса ComplexNumber с именем Real типа int (число)
        public int Real;

        // Объявление публичного поля класса ComplexNumber с именем Imaginary типа int (число)
        public int Imaginary;

        // Объявление функции которая не имеет входных параметров, но возвращает модуль данного комплекстного числа.
        public double GetModul()
        {
            // Создание локальной переменной для хранение результата вычислений.
            double modul;

            // Вычисление результата с помощью библиотечного метода Math.Sqrt вычисляющего корень выражения
            modul = Math.Sqrt(Real * Real + Imaginary * Imaginary);

            // Возврат значения в вызывающий метод
            return modul;
        }
    }
}
