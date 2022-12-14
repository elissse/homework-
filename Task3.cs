namespace Task3
{
    public class Task3
    {
        /*
         * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
         */

        /*
         * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
         * 	        0,	если x < 0,
         * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
                   −1,	если x принадлежит [1, 2), [3, 4), … .
         */
        internal static double F(double x) => x < 0 ? 0 : (Math.Floor(x) % 2 == 0) ? 1 : -1;

        /*
         * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
         * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
         * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
         * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
         */
        internal static int NumberOfDays(int year) => (year % 4 != 0) ? 365 : (year % 100 == 0 && year % 400 != 0) ? 365 : 366;

        /*
         * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
         * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
         * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
         * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
         * Вернуть ориентацию локатора после выполнения этих команд.
         */
        //internal static char Rotate2(char orientation, int cmd1, int cmd2)
        //{

        internal static char Rotate1(char Orientation1, int cmd1, int cmd2) => (cmd1 * cmd2 == 2) ? 'В' : (cmd1 * cmd2 == 1) ? 'Ю' : (cmd1 * cmd2 == -2) ? 'З' : 'С';


        //int rotate1(char orientation, int cmd) => cmd1 * cmd2 == 2? cmd = -1 : cmd1 * cmd2 == 1 ? cmd = 2 : cmd1 * cmd2 == -2 ? cmd = 1 : cmd = 0;
        //}

        /*
         * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
         * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
         * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
         * 41 — «сорок один год».
         *
         * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
         * переполнено некорректными с точки зрения русского языка решениями.
         */
        internal static String AgeDescription(int age)
        {
            string[] TensLiterals = new string[] { String.Empty, " ", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят" };
            string[] DigitsLiterals = new string[] { " ", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            int tens = (age - age % 10) / 10; // разряд десятков в возрасте
            int digit = age % 10; // разряд единиц в возрасте
            string s = $"{TensLiterals[tens]} {DigitsLiterals[digit]}";

            if (digit == 0)
                return TensLiterals[age / 10] + " лет";

            if (digit == 1)
                return $"{s} год";

            if (digit <= 4)
                return $"{s} года";

            return $"{s} лет";

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDays(1900));
            Console.WriteLine(Rotate1('С', 1, 2));
            Console.WriteLine(AgeDescription(55));
            Console.WriteLine(AgeDescription(31));
            Console.WriteLine(AgeDescription(20));
            Console.WriteLine(AgeDescription(42));
            Console.WriteLine(AgeDescription(68));
        }
    }
}