using System;

class Program
{
    static void Main(string[] args)
    {
        // получаем числа (докажи, что я ЧИСЛО) :)))
        bool isNumber;

        int n;
        do
        {
            Console.Write("n ? ");
            isNumber = int.TryParse(Console.ReadLine(), out n);

            if (!isNumber)
                Console.WriteLine("Ошибка ввода n!");

        } while (!isNumber);

        int m;
        do
        {
            Console.Write("m ? ");
            isNumber = int.TryParse(Console.ReadLine(), out m);

            if (!isNumber)
                Console.WriteLine("Ошибка ввода m!");

        } while (!isNumber);

        double x;
        do
        {
            Console.Write("x ? ");
            isNumber = double.TryParse(Console.ReadLine(), out x);

            if (!isNumber)
                Console.WriteLine("Ошибка ввода x!");

        } while (!isNumber);
        
        // начинаем работать с приколами типа int :(((
        long nClone = n;
        long mClone = m;
        long mTemp = mClone - 1;
        long nTemp = nClone + 1;

        // m = m верно n = n верно
        
        if (mTemp < int.MinValue) 
            Console.WriteLine("Значение m вышло за границы заданного типа!");
        else if ((mTemp > 0 && nClone < 0 && mTemp + Math.Abs(nClone) > int.MaxValue) || (mTemp < 0 && nClone > 0 && mTemp - Math.Abs(nClone) < int.MinValue)) // заклинание, полученное эмпирически на листочке бумаге
            Console.WriteLine("Невозможно вычислить разность в заданном типе!");
        else
        {
            int result = --m - n++;
            Console.WriteLine($"n = {n}, m = {m}, --m - n++ = {result}");
        }

        // m = m - 1 верно  n = n + 1 надо проверить
        
        if (nTemp > int.MaxValue) // проверили
            Console.WriteLine("Значение n вышло за границы заданного типа!");
        else if (mTemp * mTemp > int.MaxValue)
            Console.WriteLine("Невозможно вычислить произведение в заданном типе!");
        else
        {
            bool result = m * m < n++;
            Console.WriteLine($"n = {n}, m = {m}, m * m < n++ = {result}");
        }     

        // m = m - 1 верно  n = n + 2 надо проверить
        
        if (nTemp + 1 > int.MaxValue) // проверили 
            Console.WriteLine("Значение n вышло за границы заданного типа!");
        else
        {
            bool result = n-- > ++m;
            Console.WriteLine($"n = {n}, m = {m}, n-- > ++m = {result}");
        }

        // m = m верно  n = n + 1 верно тк n + 2 верно


        // начинаем работать с приколами типа double :((
        double tgX = Math.Tan(x);
        double polynomial = Math.Pow(5 - x, 4);

        if (double.IsInfinity(tgX) || double.IsNaN(polynomial) || double.IsInfinity(polynomial)) // проверяем результаты на нечисло и бесконечность
            Console.WriteLine("Число слишком большое/малое для вычисления!");
        else
        {
            double fraction = tgX / x;

            if (x == 0 || Math.Cos(x) == 0)
                Console.WriteLine("Нельзя вычислить!");
            else if (double.IsInfinity(fraction) || double.IsNaN(fraction))
                Console.WriteLine("Число слишком большое/малое для вычисления!");
            else
            {
                double result = fraction - polynomial;
                Console.WriteLine($"x = {x}, tg(x) / x - (5 - x)^4 = {result}");
            }
        }
    }
}

