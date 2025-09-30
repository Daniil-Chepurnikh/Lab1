using System;

namespace Task2
{
    internal class Task2
    {
        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double yCoordinate, xCoordinate;
            bool isNumber;

            do
            {
                Console.Write("Введите координату x: ");
                string? input = Console.ReadLine();
                isNumber = double.TryParse(input, out xCoordinate);
                if (!isNumber)
                    Console.WriteLine("Ошибка: Вы ввели не число!");
            } while (!isNumber);

            do
            {
                Console.Write("Введите координату y: ");
                string? input = Console.ReadLine();
                isNumber = double.TryParse(input, out yCoordinate);
                if (!isNumber)
                    Console.WriteLine("Ошибка: Вы ввели не число!");
            } while (!isNumber);

            bool isInCircle = xCoordinate * xCoordinate + yCoordinate * yCoordinate <= 1;
            bool xIsCorrect = xCoordinate >= 0;
            bool isInArea = xIsCorrect && isInCircle;

            if (isInArea)
                Console.WriteLine("Точка попала в заштрихованную область");
            else
                Console.WriteLine("Точка не попала в заштрихованную область");
        }
    }
}

