using System;
namespace elmir
{
    class Program
    {
        static void Main(string[] args)
        {
            string year;

            short a, b;

            Console.WriteLine("Здраствуйте, введите пожалуйста год вашего рождения:  ");

            year = Console.ReadLine();

            a = Convert.ToInt16(year);

            b = 2024;

            short age = Convert.ToInt16 (b - a);

            Console.WriteLine($"Ваш возраст составляет {age} года.");
            Console.WriteLine("Спасибо что использовали нашу прошрамму!!!");
            Console.WriteLine("Привет.");
            Console.ReadKey();

        }
    }
}