using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;
using SolveArray.Lib;
using SolveCalculate.Lib;
using SolveMathFirstExpression.Lib;
using SolveTabMathFunction.Lib;



namespace Tyuiu.LongortovEB.Lab3.Review.V4
{
    internal class Program
    {
        public static int indexItem;

        static void UpArrow() // стрелка вверх
        {
            indexItem--;
            if (indexItem < 1)
            {
                indexItem = 5;
            }
            drawMainMenu();
        }

        static void DownArrow() // стрелка вниз
        {
            indexItem++;
            if (indexItem > 5)
            {
                indexItem = 1;
            }
            drawMainMenu();
        }
        static void selectItem() // выбор пунка в меню
        {
            switch (indexItem)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Option3();
                    break;
                case 4:
                    Option4();
                    break;
                case 5:
                    Option5();
                    break;
            }
        }

        static void Option1() // первый пункт меню
        {

            MathFirstExpression ds = new MathFirstExpression();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Рассчитать первое математическое выражение");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.Write("Первое число = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine(ds.CalculateFirstExpression(x, y));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option1();
            }
        }

        static void Option2() // второй пункт меню
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Рассчитать второе математическое выражение");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Выполняется функция рассчёта 2 математического выражения");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option2();
            }
        }


        static void Option3() // третий пункт меню
        {
            TabMathFuction ds = new TabMathFuction();

            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Протабулировать функцию на заданном диапазоне");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Старт шага:"); int startStep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец шага:"); int endStep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            double[][] result = ds.CalculateTabMathFuction(startStep, endStep);
            // Отступы для каждой колонки
            int columnWidthX = 6;  // Ширина колонки для X
            int columnWidthFx = 10;  // Ширина колонки для F(x)
            int tableWidth = columnWidthX + columnWidthFx + 5;  // Общая ширина таблицы

            // Верхняя линия таблицы
            Console.WriteLine(new string('-', tableWidth));

            // Заголовки таблицы
            Console.WriteLine("|{0," + columnWidthX + "}|{1," + columnWidthFx + "}|", "X", "F(x)");

            // Линия после заголовков
            Console.WriteLine(new string('-', tableWidth));

            // Вывод значений из массива
            foreach (double[] element in result)
            {
                Console.WriteLine("|{0," + columnWidthX + "}|{1," + columnWidthFx + ":0.00}|", element[0], element[1]);
            }

            // Нижняя линия таблицы
            Console.WriteLine(new string('-', tableWidth));

            Console.ReadKey();

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");
            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option3();
            }
        }

        static void Option4() // четвёртый пункт меню
        {
            Calculate calc = new Calculate();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Калькулятор");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.Write("Число 1 = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2 = ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.Write(string.Format("Сумма: {0} + {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateAdd(num1, num2));
            Console.Write(string.Format("Разница: {0} - {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateSubt(num1, num2));
            Console.Write(string.Format("Разница: {0} * {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateMult(num1, num2));
            Console.Write(string.Format("Разница: {0} / {1} = ", num1, num2));
            Console.WriteLine(calc.CalculateDiv(num1, num2));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option4();
            }
        }

        static void Option5() // четвёртый пункт меню
        {

            Random random = new Random();
            ArrayCustom ds = new ArrayCustom();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Обработка одномерного массива");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.Write("x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(x1, x2);
            }
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.Write("Массив: ");
            foreach (double number in array)
            {
                Console.Write("{0}, ", number);
            }
            Console.WriteLine("");
            Console.WriteLine(string.Format("Минимальный элемент: {0} ", ds.CalculateMin(array)));
            Console.WriteLine(string.Format("Максимальный элемент: {0} ", ds.CalculateMax(array)));
            Console.WriteLine(string.Format("Среднее: {0} ", ds.CalculateMid(array)));
            Console.WriteLine(string.Format("Медиана: {0} ", ds.CalculateMedian(array)));
            Console.WriteLine(string.Format("Количество чётных элементов: {0} ", ds.CalculateNumberOfEven(array)));
            Console.WriteLine(string.Format("Количество нечётных элементов: {0} ", ds.CalculateNumberOfOdd(array)));
            Console.WriteLine(string.Format("Количество элементов с признаками делимости на 2: {0} ", ds.SignsOfDivisibilityByTwo(array)));
            Console.WriteLine(string.Format("Количество элементов с признаками делимости на 3: {0} ", ds.SignsOfDivisibilityByThree(array)));
            Console.WriteLine(string.Format("Количество элементов с признаками делимости на 5: {0} ", ds.SignsOfDivisibilityByFive(array)));
            Console.WriteLine(string.Format("Количество элементов с признаками делимости на 10: {0} ", ds.SignsOfDivisibilityByFive(array)));
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option5();
            }
        }



        static void OptionFS() // выбор справки в главном меню
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("Справка");
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Справочные сведения по работе с программной");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" Раздел меню");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(" Описание");
            Console.SetCursorPosition(64, 6);
            Console.WriteLine(" Параметр ком. строки");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 1. Расчитать первое математическое");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine(" Вычисляет математическое выражение");
            Console.SetCursorPosition(64, 8);
            Console.WriteLine(" /1 ");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 2. Рассчитать второе математическое");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine(" Вычисляет математическое выражение");
            Console.SetCursorPosition(64, 10);
            Console.WriteLine(" /2 ");
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" 3. Протабулиролвать функцию");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine(" Табулирует функцию");
            Console.SetCursorPosition(64, 12);
            Console.WriteLine(" /3 ");
            Console.SetCursorPosition(1, 14);
            Console.WriteLine(" 4. Калькулятор");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(" Выполняет расчёт +, -, *, / ");
            Console.SetCursorPosition(64, 14);
            Console.WriteLine(" /4 ");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine(" 5. Обработка одномерного массива ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine(" Обрабатывает одномерный массив ");
            Console.SetCursorPosition(64, 16);
            Console.WriteLine(" /5 ");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine(" Программу разработал Лонгортов Егор Борисович | НТм-23-1 | ТИУ 2024");
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернутся в главное меню");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                OptionFS();
            }
        }


        static void OptionExit() // выход при F10
        {
            Environment.Exit(0);
        }

        static void drawMainMenu() // Рисуем главное меню
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.ResetColor();
            Console.Write("-------------------------------------------------------");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("|               Лабораторная работа №3                |");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("|            Создание консольного интерфейс           |");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("|        Выполнил Лонгортов Егор Борисович            |");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("|             ТИУ-2024, группа НТм-23-1               |");
            Console.SetCursorPosition(0, 5);
            Console.Write("-------------------------------------------------------");
            Console.WriteLine("     ");
            switch (indexItem)
            {
                case 0:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 1:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 2:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 4.");
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.WriteLine(" Меню:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапазоне");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" 4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" 5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Выберите пункт меню стрелками или нажмите номер пункта [ ] ");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("_______________________________________________________");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[9]");
            Console.ResetColor();
            Console.Write(" - Справка | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[0]");
            Console.ResetColor();
            Console.Write(" - Выход    Перемещение:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[СТРЕЛКА ВНИЗ]");
            Console.ResetColor();
            Console.Write(" | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("[СТРЕЛКА ВВЕРХ]");
            Console.ResetColor();

            Console.SetCursorPosition(57, 15);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Option1();
                    break;
                case ConsoleKey.D2:
                    Option2();
                    break;
                case ConsoleKey.D3:
                    Option3();
                    break;
                case ConsoleKey.D4:
                    Option4();
                    break;
                case ConsoleKey.D5:
                    Option5();
                    break;
                case ConsoleKey.D9:
                    OptionFS();
                    break;
                case ConsoleKey.D0:
                    OptionExit();
                    break;
                default:
                    drawMainMenu();
                    break;
                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;
                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;
                case ConsoleKey.Enter:
                    selectItem();
                    break;
            }

        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);

            foreach (string arg in args)
            {
                if (arg == "\\1")
                {
                    Option1();
                }
                if (arg == "\\2")
                {
                    Option2();
                }
                if (arg == "\\3")
                {
                    Option3();
                }
                if (arg == "\\4")
                {
                    Option4();
                }
                if (arg == "\\5")
                {
                    Option5();
                }
            }

            drawMainMenu();
            Console.ReadKey();
        }
    }
}