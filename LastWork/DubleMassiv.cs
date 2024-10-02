using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class DubleMassiv
    {
                     
        public static int[,] SawpEdgeSignsArray(int a, int b)
        {
            int[,] array = Helper.GenerateRandomIntMatrix(a, b);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ( i == 0 || j == 0 || i == array.GetLength(0) - 1 || j == array.GetLongLength(1) - 1) array[i, j] *= -1;

                }
            }

            return array;
        }
            
        public static int[,] CreateTableMultiplication(int a, int b)
        {
            if (a != 9 && b != 9) throw new ArgumentOutOfRangeException("Стороны массива не 9!");

            int[,] array = new int[a, b];

            for (int i = 1; i <= array.GetLength(0) ; i++)
            {
                for (int j = 1; j <= array.GetLength(1) ; j++)
                {
                    array[i - 1, j - 1] = i * j;

                }
            }

            return array;

        }

        public static int[,] CreateChessBord(int a, int b)
        {
            int[,] array = new int[a, b];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j =0; j < array.GetLength(1); j++)
                {
                    if (i % 2 != 0 && j % 2 == 0 || i % 2 == 0 && j % 2 != 0) array[i, j] = 1;

                }
            }


            return array;

        }



        public static string[,] ReservetionSeatsInCinema(int x, int y )
        {

            string[,] mas = new string[8, 8]
            {
               { "0" , "0" , "0" , "1" , "0" , "0" , "0" , "1" },
               { "0" , "0" , "0" , "0" , "1" , "0"  ,"1" , "0" },
               { "0" , "0" , "1" , "0" , "1" , "0" , "1" , "0" },
               { "0" , "1" , "0" , "0" , "0" , "0" , "0" , "0" },
               { "0" , "1" , "0" , "0" , "0" , "0" , "1" , "0" },
               { "0" , "1" , "0" , "0" , "0" , "0" , "0" , "1" },
               { "0" , "1" , "0" , "0" , "0" , "0" , "0" , "1" },
               { "0" , "1" , "0" , "0" , "0" , "0" , "1" , "0" }
            };



            bool is_rule = true;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1) - 1; j++)
                {
                    if (mas[i, j] == "1" && (mas[x, y + 1] == "1" || mas[x, y - 1] == "1"))
                    {
                        is_rule = false;
                        break;
                    }

                }
                if (!is_rule) break;


            }
            if (is_rule == true ) return mas;
            else  throw new ArgumentException("Рассадка не по правилам");

        }



        public static string CalculateAmountAverageIncome(int[,] mas_a)
        {
            int[] mas_sum = CalculateAmountAverageIncomeTimeSumm(mas_a);
            int[] mas_sr = CalculateAmountAverage(mas_sum);
            string info = CalculateAmountMinAndMax(mas_a);
            return $"Суммы за все месяцы по каждому магазину:{string.Join(", ", mas_sum)}\n" +
                $"Средний доход по каждому месяцу: {string.Join(", ", mas_sr)}\n" +
                $"Мин.и Макс. доход за весь период-{info}";

        }

        public static int[] CalculateAmountAverageIncomeTimeSumm(int[,] mas_a)
        {
            //Фирма имеет 10 магазинов.
            //Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве.
            //Заполнить массив случайными вещественными числами. Высчитать:
            //а) суммарный доход по каждому магазину;                     

            int[] sum = new int[10];

            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_a.GetLength(1); j++)
                {
                    sum[i] += mas_a[i, j];
                }

            }

            return sum;

        }
        public static int[] CalculateAmountAverage(int[] mas)
        {
            //б) средний доход по каждому месяцу;
            int[] sr = new int[10];

            for (int i = 0; i < 10; i++) sr[i] = mas[i] / 6;

            return sr;
        }
        public static string CalculateAmountMinAndMax(int[,] mas_a)
        {
            //в) мин.и макс. доход за весь период.
            int min = mas_a[0, 0];
            int max = mas_a[0, 0];
            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_a.GetLength(1); j++)
                {
                    if (mas_a[i, j] < min) min = mas_a[i, j];
                    if (mas_a[i, j] > max) max = mas_a[i, j];
                }

            }
            return $"min-{min}, max-{max}";
        }

        public static int FindNumberAllNeighborsSameTime(int a, int b)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно. 
            //Примечание: соседями элемента считать только 4 потенциальных соседа:
            //на 1 выше, на 1 ниже, на 1 левее и на 1 правее.
            //Обязательно учесть выход за границы массива!
            //При определении критерия, считать сумму соседей для каждого элемента, даже для элемента [0;0]
            //(у него, кстати, будет всего два соседа - [0; 1] и [1; 0]).

            int[,] mas = Helper.GenerateRandomIntMatrix(a, b);
            
            int count = 0;
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum = (i > 0 ? mas[i - 1, j] : 0)
                        + (i < mas.GetLength(0) - 1 ? mas[i + 1, j] : 0)
                        + (j > 0 ? mas[i, j - 1] : 0)
                        + (j < mas.GetLength(1) - 1 ? mas[i, j + 1] : 0);

                    if (mas[i, j] > sum) count++;
                }

            }
            return count;
        }


        public static int[,] FillCharArrayFromInner(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1) || (i >= j && i >= mas.GetLength(0) - j - 1) ? 1 : 0;

                }

            }
            return mas;
        }



        public static void ImplementMatrixMultiplicationIntegersInner(int[,] mas_a, int[,] mas_b, ref int[,] mas_c)
        {
            //Реализовать перемножение матриц целых чисел.
            //Примеры не сложно найти в сети.
            //Важно их понять и адаптировать для ваших двух произвольных массивов. Проверить входное условие перемножения
            //(число столбцов 1-го массива == числу строк 2-го массива)


            int[,] mas_c1 = new int[mas_a.GetLength(0), mas_b.GetLength(1)];

            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_b.GetLength(1); j++)
                {
                    mas_c1[i, j] = 0;

                    for (int k = 0; k < mas_a.GetLength(1); k++)
                    {
                        mas_c1[i, j] += mas_a[i, k] * mas_b[k, j];
                    }
                }
            }

            mas_c = mas_c1;
        }




    }
}
