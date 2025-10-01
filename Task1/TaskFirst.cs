using System;

namespace Task1
{
    internal class Task1
    {
        /// <summary>
        /// Основная функция
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Это лабораторная работа Даниила Чепурных РИС25-1-1 (0_0(");
            bool isNumber;
            string? input;
            int n = 0;
            int m = 0;
            do
            {
                long bigAbsNumber;
                Console.Write("Ведите число n: ");
                input = Console.ReadLine();
                isNumber = long.TryParse(input, out bigAbsNumber);
                if (!isNumber)
                    Console.WriteLine("Ошибка: Вы ввели не число!");
                else if (bigAbsNumber > 2147483647 || bigAbsNumber < -2147483648)
                {
                    Console.WriteLine("Ошибка: Вы ввели число выходящее за диапазон допустимых значений!");
                    isNumber = false;
                }
                else
                    n = (int) bigAbsNumber;
            } while (!isNumber);

            do
            {
                long bigAbsNumber;
                Console.Write("Ведите число m: ");
                input = Console.ReadLine();
                isNumber = long.TryParse(input, out bigAbsNumber);
                if (!isNumber)
                    Console.WriteLine("Ошибка: Вы ввели не число!");
                else if (bigAbsNumber > 2147483647 || bigAbsNumber < -2147483648)
                {
                    Console.WriteLine("Ошибка: Вы ввели число выходящее за диапазон допустимых значений!");
                    isNumber = false;
                }
                else
                    m = (int)bigAbsNumber;
            } while (!isNumber);

            int result = --m - n++;
            Console.WriteLine($" --m - n++ = {result}. После действий m = {m}; n = {n}.");
            bool bresult = m * m < n++;
            Console.WriteLine($"m * m < n++ Неравенство: {bresult}. После действий m = {m}; n = {n}.  ");
            bresult = n-- < ++m;
            Console.WriteLine($" n-- < ++m Неравенство: {bresult}. После действий m = {m}; n = {n}.");

            double x;
            do
            {
                Console.Write("Введите число x: ");
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out x);
                if (!isNumber)
                    Console.WriteLine("Ошибка: Вы ввели не число!");
            } while (!isNumber);

            if (x == 0 || Math.Cos(x) == 0)
                Console.WriteLine("Ошибка: нельзя делить на нуль!");
            else
            {
                double dresult = Math.Tan(x) / x - Math.Pow(5 - x, 4);
                Console.WriteLine($"x = {x}; (tg(x) / x) - (5 - x)^4 = {dresult} ");
            }
        }
        /*  Правила БЛОК-СХЕМ:

            Закруглённый прямоугольник - начало/окончание.
            Прямоугольник - действие программы без пользователя.
            Параллелограмм - ввод/вывод.
            Ромб - условие ветвления/цикла.
            Маленький кружочек - блок соединитель (аккуратно переносить элементы части алгоритма).
            Стрелочка - направление выполнения/порядок команд.
            Линия - естественный порядок.
            Шестиугольник - цикл с параметром (от 1 до n. После запятой шаг цикла. Писать на понятном нормальному человеку языке без кода на конкретном языке)
            + - да; - - нет.
            Элемент комментарий - можно пояснять нестандартное выноситься в любую свободную область.
            В циклах и ветвлениях ВСЕГДА 1 Вход 2 Выхода.
        */
    }
}
