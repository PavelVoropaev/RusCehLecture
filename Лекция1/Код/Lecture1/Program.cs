namespace Lecture1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Обявление переменной Number в методе Main класса Program, так как это элементарный тип (см слайд 4 лекции 1)
            // вызов конструктора по умолчанию не обязателен. В таких переменных по умолчанию 0
            int five;

            // Присвание переменной значения 5, теперь это просто цифра 5 с красивым названием.
            five = 5;

            // Создание экземпляра нашего класса ComplexNumber. Сложный пользовательский тип, состоящий из нескольких полей,
            // вызов конструктора обязателен, для работы с полями.
            ComplexNumber myComplex = new ComplexNumber();

            // Присваивание полям Imaginary и Real экземпляра класса ComplexNumber значение 4
            myComplex.Imaginary = 1;
            myComplex.Real = 4;

            // Создание переменной типа double
            double modul;

            // Вызов функции GetModul() экземпляра myComplex, и сохранение возвращаеммного значение в переменную modul
            modul = myComplex.GetModul();

            // Вывод на консоль всех нащих переменных, после преобразования их к строке.
            Console.WriteLine("Мнимая часть числа: " + myComplex.Imaginary.ToString());
            Console.WriteLine("Реальная часть числа: " + myComplex.Real.ToString());
            Console.WriteLine("Модуль комплексного числа: " + modul.ToString());
            Console.WriteLine("Просто 5 которая хранится в переменной: " + five.ToString());

            Console.Read();
        }
    }
}
