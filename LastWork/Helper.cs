using LastWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class Helper
    {
        public static void PrintResult(int value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(double value)
        {
            Console.WriteLine(value);
        }
        public static void PrintResult(string value)
        {
            Console.WriteLine(value);
        }

       
        public static int[] GetRandomIntArray(int a)
        {
            Random rnd = new Random();

            int[] array = new int[a];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0,99);
            }
            return array;
        }

        public static double[] GetRandomDoubleArray(int a)
        {
            Random rnd = new Random();

            double[] array = new double[a];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 99);
            }
            return array;
        }

        public static int[,] GenerateRandomIntMatrix(int a, int b)
        {
            Random rnd = new Random();

            int[,] array = new int[a, b];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }

            return array;
        }

        public static double[,] GenerateRandomDoubleMatrix(int a, int b)
        {
            Random rnd = new Random();

            double[,] array = new double[a, b];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +",");
            }
            Console.WriteLine();
        }

        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        

        public static void PrintMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }


        }

        public static void PrintMatrix(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }


        }

        public static void PrintMatrix(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }

        }

        public static int SaveInput(int min, int max, string message)
        {
            int num;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }

        public static double SaveInput(double min, double max, string message)
        {
            double num;
            do
            {
                Console.Write($"{message} [{min}-{max}]: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }

        public static void Line(string messege)
        {
            int a = 60;
            int b = 0;
            
            while (b < a)
            {
                if (b == a / 2) Console.Write(messege);
                else Console.Write("-");
                b++;

            }
            Console.WriteLine();

        }


    }
}
