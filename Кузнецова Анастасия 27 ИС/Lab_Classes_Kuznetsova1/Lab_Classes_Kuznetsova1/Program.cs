using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Classes_Kuznetsova1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создание объекта класса Car
            Car myCar = new Car();

            // 2. Инициализация открытых полей объекта данными из 11 варианта
            myCar.marka = "Жигули";
            myCar.gosNomer = "Т144ТО";
            myCar.probeg = 10350;

            // 3. Вывод на экран значений свойств (полей) объекта
            Console.WriteLine("--- Данные об автомобиле (вывод через Main) ---");
            Console.WriteLine($"Марка: {myCar.marka}");
            Console.WriteLine($"Гос. номер: {myCar.gosNomer}");
            Console.WriteLine($"Пробег: {myCar.probeg} км\n");

            // 4. Вызов встроенного метода Show() для демонстрации данных
            myCar.Show();

            // 5. Расчет среднегодового пробега для возраста 2 года и вывод на печать
            int ageParam = 2;
            float averageProbeg = myCar.CalculateAverageProbeg(ageParam);

            Console.WriteLine($"\nСреднегодовой пробег за {ageParam} года: {averageProbeg} км/год.");

            // Ожидание нажатия клавиши, чтобы консоль не закрывалась
            Console.ReadKey();
        }
    }

    // Описание класса Car в соответствии с вариантом 11
    class Car
    {
        // Открытые поля для хранения марки, гос. номера и пробега
        public string marka;
        public string gosNomer;
        public int probeg;

        // Метод — показать на экране данные об автомобиле
        public void Show()
        {
            Console.WriteLine("--- Вызов метода Show() ---");
            Console.WriteLine($"Автомобиль {marka} с госномером {gosNomer} имеет пробег {probeg} км.");
        }

        // Метод расчета среднего пробега для заданного возраста автомобиля (передается в качестве параметра)
        public float CalculateAverageProbeg(int age)
        {
            if (age <= 0)
            {
                return probeg; // Защита от деления на ноль, если передан некорректный возраст
            }

            // Расчет: общий пробег делим на количество лет
            return (float)probeg / age;
        }
    }
}

