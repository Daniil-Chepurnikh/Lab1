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
            double denominator = 3 * a * b * b - b * b * b;
            double numerator = cubeDifference - (a * a * a - 3 * a * a * b);
            double fraction = numerator / denominator;
            Console.WriteLine("Результат вычисления (double) = " + fraction);

            float fa = 1000F;
            float fb = 0.0001F;

            float fcubeDifference = (float)((fa - fb) * (fa - fb) * (fa - fb));
            float fsubtrahend = (float)(fa * fa * fa - 3 * fa * fa * fb);
            float fdenominator = (float)(3 * fa * fb * fb - fb * fb * fb);
            float fnumerator = (float)(fcubeDifference - (fa * fa * fa - 3 * fa * fa * fb));
            float ffraction = fnumerator / fdenominator;
            Console.WriteLine("Результат вычисления (float) = " + ffraction);
        }
    }
} 

