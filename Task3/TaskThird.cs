using System;

namespace Task3
{
    internal class Task3
    {
        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double a = 1000;
            double b = 0.0001;

            double cubeDifference = (a - b) * (a - b) * (a - b);
            Console.WriteLine("Куб разности с типом double: " + cubeDifference);
            float fcubeDifference = (float)cubeDifference;
            Console.WriteLine("Куб разности с типом float: " + fcubeDifference);


            double subtrahend = a * a * a - 3 * a * a * b;
            Console.WriteLine("Вычитаемое с типом double: " + subtrahend);
            float fsubtrahend = (float)subtrahend;
            Console.WriteLine("Вычитаемое с типом float: " + fsubtrahend);

            double denominator = 3 * a * b * b - b * b * b;
            Console.WriteLine("Знаменатель с типом double: " + denominator);
            float fdenominator = (float)denominator;
            Console.WriteLine("Знаменатель с типом float: " + fdenominator);

            double numerator = cubeDifference - subtrahend;
            Console.WriteLine("Числитель с типом double: " + numerator);
            float fnumerator = (float)(fcubeDifference - fsubtrahend);
            Console.WriteLine("Числитель с типом float: " + fnumerator);

            double fraction = numerator / denominator;
            Console.WriteLine("Результат с типом double: " + fraction);
            float ffraction = fnumerator / fdenominator;
            Console.WriteLine("Результат с типом float: " + ffraction);
        }
    }
}

