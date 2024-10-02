using System;
using System.Collections.Generic;

namespace LastWork
{
    class Program
    {
        



        public const int MyConst = 844;
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;

            //-----------------------------------Peremenye---------------------------------------------
            Helper.Line("Peremenye");
            //1
            //Console.WriteLine("Введите числа для суммы int a и double b:");

            //int a = int.Parse(Console.ReadLine());

            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Peremenye.GetSum(a, b);

            //Console.WriteLine($"привет, <{a}>!\n<{a}> + <{b}> = <{c}>\nпока, < {b} > ...");

            //2

            //Console.Write("Введите два целых числа:");

            //int a2 = int.Parse(Console.ReadLine());

            //int b2 = int.Parse(Console.ReadLine());

            //double c2 = Peremenye.GetResultEquation(a2, b2);

            //Console.WriteLine($"Ваш ответ: {c2}");

            //3

            //Console.WriteLine("Введите два слова:");

            //string a3 = Convert.ToString(Console.ReadLine());

            //string b3 = Convert.ToString(Console.ReadLine());

            //Peremenye.SwapsString(a3, b3);

            //4

            //Console.WriteLine("Введите три целых числа:");

            //Console.WriteLine(Peremenye.GetAnswerLinearEquation(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            //5

            //Console.WriteLine("Введите три числа:");

            //int a5 = int.Parse(Console.ReadLine());

            //int b5 = int.Parse(Console.ReadLine());

            //int c5 = int.Parse(Console.ReadLine());

            //Peremenye.GetAnswerQuadraticEquation(a5, b5, c5);

            //----------------------------------PrivedenueTipov------------------------------------
            Helper.Line("PrivedenueTipov");

            //1

            //int res = PrivedenieTipov.SumOfThreeDigitConstNumber(MyConst);

            //Console.WriteLine(res); // Console.WriteLine(PrivedenieTipov.SumOfThreeDigitConstNumber(MyConst))

            //2

            //Console.WriteLine("Введите координаты выстрела х1 и х2:");

            //int x = int.Parse(Console.ReadLine());

            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine(PrivedenieTipov.GetResultShot(x, y));

            //3

            //Console.WriteLine("Введите трехзначное число:");

            //int a3 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a3} ({PrivedenieTipov.GetResultConditionThreeDigitConstNumber(a3)})");

            //4

            //Console.WriteLine("Введите трехзначное число:");

            //int a4 = int.Parse(Console.ReadLine());

            //Console.WriteLine(PrivedenieTipov.GetNewThreeDigitNumber(a4));

            //5

            //Console.WriteLine("Введитедробное число на проверку остака:");

            //double a5 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"{a5},0({PrivedenieTipov.GetResultExaminationRemainder(a5)})");

            //------------------------------Vetvlenia-----------------------------------------
            Helper.Line("Vetvlenia");

            //1

            //Console.WriteLine("Введите два числа");

            //int a = int.Parse(Console.ReadLine());

            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Ваш ответ:{Vetvlenia.GetAnswerComputations(a, b)}");

            //2

            //Console.WriteLine("Введите координаты точки x и y");

            //int x = int.Parse(Console.ReadLine());

            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Координаты принадлежат: {Vetvlenia.GetResultQuarter(x, y)}-й четверти");

            // 3 

            //Console.WriteLine("Введите три числа");

            //int a3 = int.Parse(Console.ReadLine());

            //int b3 = int.Parse(Console.ReadLine());

            //int c3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Vetvlenia.GetNumbersAscending(a3, b3, c3));

            // 4

            //while (true)
            //{
            //    Console.Clear();

            //    Console.WriteLine("Введите число от 0 до 99:");

            //    int a4 = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Ваше число - {Vetvlenia.GetWrittenNumber(a4)}");

            //    Console.ReadLine();
            //}

            //5

            //while(true)
            //{
            //    Console.Clear();

            //    Console.WriteLine("Введите три стороны треугольника:");

            //    int a5 = int.Parse(Console.ReadLine());

            //    int b5 = int.Parse(Console.ReadLine());

            //    int c5 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(Vetvlenia.GetAnswerExistsTriangle(a5, b5, c5));

            //    Console.ReadLine();
            //}

            //------------------------------------Cycle---------------------------------------------
            Helper.Line("Cycle");

            ////1

            Console.WriteLine("Введите число:");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join( ' ', Cycle.GetNumberDivideOnA(a)));

            ////2

            //Console.WriteLine("Введите число:");

            //int a2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.CountSquareIsSmaller(a2));

            ////3

            //Console.WriteLine("Введит число: ");

            //int a3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.GetBigDivider(a3));

            ////4

            //Console.WriteLine("Введите число А:");

            //int a4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("введите число Б:");

            //int b4 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Сумма всех чисел в диапозоне от {a4} до {b4} равно:{Cycle.SumAllNumberInDiapozonDivideOnSeven(a4, b4)}");

            ////5

            //Console.WriteLine("Введите первое число:");

            //int a5 = int.Parse(Console.ReadLine());

            //Console.WriteLine("введите второе число:");

            //int b5 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.BindBigGenetalDevideEuclid(a5, b5));

            ////6

            //Console.WriteLine("Введите целое положительное число, так что бы оно могло являтся кубом другого числа:");

            //int a6 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.FindNumberMetodHalfDivision(a6));

            ////7

            //Console.WriteLine("Введите число произвольной длинны: ");

            //int a7 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Количество не четных цифр в числе {a7} равно {Cycle.FindCountOddNumber(a7)} ");

            ////8

            //Console.WriteLine("Введите число произвольной длинны: ");

            //int a8 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.ReversNumber(a8));

            ////9

            //Console.WriteLine("Введите первое целое положительное число: ");

            //int a9 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите второе целое положительное число: ");

            //int b9 = int.Parse(Console.ReadLine());

            //Console.WriteLine(Cycle.GetResultatComparisonTwoNumber(a9, b9));


            //-------------------------------------Massiv-----------------------------------------
            Helper.Line("Massiv");

            ////1

            //Console.WriteLine("Введите длинну массива: ");

            //int a1 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Колличесиво нечетных и четных элементов массива: {string.Join(',', Massiv.СountEvenOddNumberInArray(a1))}");

            ////2

            //Console.WriteLine("Введите длинну массива: ");

            //int a2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.GetArrayWhenThirdNumberСhange(a2)));

            ////3

            //Console.WriteLine("Введите длинну первого массива массива: ");

            //int a3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите длинну второго массива массива: ");

            //int b3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.TwoInOneArray(a3, b3)));

            ////4

            //Console.WriteLine("Введите длинну массива: ");

            //int a4 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.ToSwapArray(a4)));

            ////5

            //Console.WriteLine("Введите длинну массива: ");

            //int a5 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.ToSwapArrayOnOneElement(a5)));

            ////6

            //Console.WriteLine("Введите длинну массива: ");

            //int a6 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.SwapPlacesOddAndEvenNumberInArray(a6)));

            ////7

            //Console.WriteLine("Введите длинну массива: ");

            //int a7 = int.Parse(Console.ReadLine());

            //Massiv.SolutionOfThreeConditions(a7);

            ////8

            //Console.WriteLine("Введите длинну массива: ");

            //int a8 = int.Parse(Console.ReadLine());

            //Console.WriteLine(string.Join(',', Massiv.SortArrayUpInsert(a8)));

            ////9

            //Console.WriteLine("Введите длинну массива: ");

            //int a9 = int.Parse(Console.ReadLine());

            //int[] array = Helper.GetRandomIntArray(a9);

            //Helper.PrintArray(array);

            //Console.WriteLine("Добавьте любое значение в начало массива: ");

            //int b9 = int.Parse(Console.ReadLine());

            //array = Massiv.AddElementToBeginingArray(array, b9);

            //Helper.PrintArray(array);

            //Console.WriteLine("Добавьте любое значение в конец массива: ");

            //int c9 = int.Parse(Console.ReadLine());

            //array = Massiv.AddElementInTheEndArray(array, c9);

            //Helper.PrintArray(array);

            //Console.WriteLine("Добавьте любое значение в середину массива: ");

            //int d9 = int.Parse(Console.ReadLine());

            //array = Massiv.AddElementToTheMiddleArray(array, d9);

            //Helper.PrintArray(array);

            //Console.WriteLine("Введите любое значение: ");

            //int f9 = int.Parse(Console.ReadLine());

            //Console.WriteLine("По какому индексу: ");

            //int g9 = int.Parse(Console.ReadLine());

            //Massiv.AddElementToTheIndexInArray(ref array, f9, g9);

            //Helper.PrintArray(array);

            //-------------------------------DoubleArray-------------------------------------
            Helper.Line("DoubleArray");


            ////1

            //Console.WriteLine("Введите длины сторон двумерного массива:");

            //int a = int.Parse(Console.ReadLine());

            //int b = int.Parse(Console.ReadLine());

            //Helper.PrintMatrix(DubleMassiv.SawpEdgeSignsArray(a, b));

            ////2

            //Console.WriteLine("Введите длины сторон двумерного массива:");

            //int a2 = int.Parse(Console.ReadLine());

            //int b2 = int.Parse(Console.ReadLine());

            //Helper.PrintMatrix(DubleMassiv.CreateTableMultiplication(a2, b2));

            ////3

            //Console.WriteLine("Введите стороны квадрата:");

            //int a3 = int.Parse(Console.ReadLine());

            //int b3 = int.Parse(Console.ReadLine());

            //Helper.PrintMatrix(DubleMassiv.CreateChessBord(a3, b3));


            ////4
            //Console.WriteLine("Введите нужное место, соблюдая ковидные меры:");

            //int a4 = int.Parse(Console.ReadLine());

            //int b4 = int.Parse(Console.ReadLine());

            //Helper.PrintMatrix(DubleMassiv.ReservetionSeatsInCinema(a4, b4));

            ////5
            //Console.WriteLine("Введите колличество месяцев и число магазинов");
            //int a5 = int.Parse(Console.ReadLine());
            //int b5 = int.Parse(Console.ReadLine());

            //Console.WriteLine(DubleMassiv.CalculateAmountAverageIncome(Helper.GenerateRandomIntMatrix(a5, b5)));


            ////6

            //Console.WriteLine("Введите длинну и ширину массива");
            //int a6 = int.Parse(Console.ReadLine());
            //int b6 = int.Parse(Console.ReadLine());

            //Console.WriteLine(DubleMassiv.FindNumberAllNeighborsSameTime(a6, b6));

            ////7

            //Console.WriteLine("Введите длинну и ширену массива: ");

            //int a7 = int.Parse(Console.ReadLine());

            //int b7 = int.Parse(Console.ReadLine());

            //int[,] array = new int[a7, b7];

            //int[,] mas = DubleMassiv.FillCharArrayFromInner(array);

            //Helper.PrintMatrix(mas);

            //8






            Helper.Line("Passport");


            //Passport

            Passport.GetAllInfo();

            // Monster





        }
    }
}
