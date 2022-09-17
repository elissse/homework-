using System.Security.Cryptography;

namespace Task4
{
    public class Task4
    {
        /*
         * В решениях следующих заданий предполагается использование циклов.
         */

        /*
         * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
         * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
         * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

        +++++
        +   +
        +++++

         */
        internal static void PrintFrame1(int width, int height, char frameChar = '+')
        {
            for (int i = 0; i < width; i++)
                Console.Write(frameChar);
            Console.Write("\n");
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write(frameChar);
                for (int j = 0; j < width - 2; j++)
                    Console.Write(' ');
                Console.Write(frameChar + "\n");
            }
            for (int i = 0; i < width; i++)
                Console.Write(frameChar);
            Console.Write("\n");

        }

        /*
         * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
         */
        internal static void PrintFrame2(int width, int height, char frameChar = '+')
        {
            int i = 0;
            while (i < width) {
                Console.Write(frameChar);
                i++;
            }

            Console.Write('\n');

            int k = 0;

            while (k < height - 2)
            {
                Console.Write(frameChar);
                int l = 0;
                while (l < width - 2)
                {
                    Console.Write(' ');
                    l++;
                }
                Console.WriteLine(frameChar);
                k++;
            }

            int j = 0;

            while (j < width)
            {
                Console.Write(frameChar);
                j++;
            }

            Console.Write("\n");
        }


        /*
         * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
         * используя алгоритм Евклида:
         * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
         * где «mod» обозначает операцию взятия остатка от деления.
         */
        internal static long Gcd(long a, long b)
        {
            if (a == 0)
                return b;
            return Gcd(b % a, a);
        }

        /*
         * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
         * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
         * Полученное число является приближенным значением функции exp в точке X.
         */
        internal static double Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Factorial(n - 1) * n;
        }
        internal static double ExpTaylor(double x, int n)
        {
            if (n == 1)
                return 1 + x;
            return ExpTaylor(x, n - 1) + Math.Pow(x, n) / Factorial(n);
        }

        public static void Main(string[] args)
        {
            PrintFrame1(5, 3, '+');
            PrintFrame1(5, 5, '+');
            PrintFrame2(7, 3, '+');
            Console.WriteLine(Gcd(50, 25));
            Console.WriteLine(ExpTaylor(9d, 9));
        }
    }
}