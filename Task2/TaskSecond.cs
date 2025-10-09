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
            bool isNumber;

            double xCoordinate;
            do
            {
                Console.Write("x ? ");
                string? input = Console.ReadLine();
                isNumber = double.TryParse(input, out xCoordinate);
                if (!isNumber)
                    Console.WriteLine("Ошибка ввода x!");
            } while (!isNumber);

            double yCoordinate;
            do
            {
                Console.Write("y ? ");
                string? input = Console.ReadLine();
                isNumber = double.TryParse(input, out yCoordinate);
                if (!isNumber)
                    Console.WriteLine("Ошибка ввода y!");
            } while (!isNumber);

            bool isInCircle = xCoordinate * xCoordinate + yCoordinate * yCoordinate <= 1;
            bool xIsCorrect = xCoordinate >= 0;
            bool isInArea = xIsCorrect && isInCircle;

            Console.WriteLine(isInArea);
        }
    }
}

