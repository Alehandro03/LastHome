using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class Massiv
    {
        public static int[] СountEvenOddNumberInArray(int a)
        {

            int[] array = Helper.GetRandomIntArray(a);

            int odd = 0;

            int even = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) odd++;

                else even++;

            }

            int[] mas = new int[2] { odd, even };

            return mas;

        }

        public static int [] GetArrayWhenThirdNumberСhange(int a)
        {
            if (a < 3) throw new ArgumentException("Длинна массива, меньше длинны , выполнения условия! ");        

            int[] mas = Helper.GetRandomIntArray(a);

            for(int i = 2; i < mas.Length; i += 3)
            {
                mas[i] = mas[i - 2] + mas[i - 1];
            }

            return mas;


        }

        public static int[] TwoInOneArray(int a, int b)
        {
            Random rnd = new Random();

            int[] mas1 = new int[a];

            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = rnd.Next(1, 20);
            }

            int[] mas2 = new int[b];

            for (int i = 0; i < mas2.Length; i++)
            {
                mas2[i] = rnd.Next(1, 20);
            }

            int[] masAll = new int[a + b];
        

            for (int i = 0; i < mas2.Length + mas1.Length; i++)
            {
                if (mas1.Length > i) masAll[i] = mas1[i];
                else masAll[i] = mas2[i - mas1.Length];

            }

            return masAll;

           
        }

        public static int[] ToSwapArray(int a)
        {

            int[] mas1 = Helper.GetRandomIntArray(a);

            int[] mas2 = new int[a];            

            int middleLength = mas1.Length / 2;

            if (mas1.Length % 2 != 0) middleLength += 1;

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1.Length > i + middleLength) mas2[i] = mas1[i + middleLength];

                else if(mas1.Length % 2 != 0) mas2[i] = mas1[(i + 1) - middleLength];

                else mas2[i] = mas1[i  - middleLength];
            }

            return mas2;

        }

        public static int[] ToSwapArrayOnOneElement(int a)
        {

            int[] mas1 = Helper.GetRandomIntArray(a);

            int lastNumber = mas1[mas1.Length - 1];

            for(int i = mas1.Length - 1; i > 0; i--)
            {
                mas1[i] = mas1[i - 1];
            }

            mas1[0] = lastNumber;

            return mas1;
        }


        public static int[] SwapPlacesOddAndEvenNumberInArray(int a)
        {

            int[] mas1 = Helper.GetRandomIntArray(a);

            for(int i = 1; i < mas1.Length; i +=2)
            {
                if (i + 1 < mas1.Length)
                {
                    int tmp = mas1[i];
                    mas1[i] = mas1[i + 1];
                    mas1[i + 1] = tmp;
                }
                else break;
               
            }

            return mas1;
        }

        public static void SolutionOfThreeConditions(int a)
        {
           
            int[] mas1 = Helper.GetRandomIntArray(a);

            bool tmp = false;
            int min = mas1[0];

            int sum = 0;

            for (int i = 0; i < mas1.Length; i++)
            {

                if (mas1[i] < min) min = mas1[i];  

                if (mas1[i] == 0) tmp = true;

                if (tmp == true) sum += mas1[i];
                
                
            }

            Console.WriteLine($"В массиве: {string.Join(',', mas1)}.\n" +
                $"Минимальный по модулю элемент: {min}.\nCумма элементов расположеная после первого 0 элемента равна {sum}");
        }

        public static string SortArrayUpInsert(int a)
        {

            int[] mas1 = Helper.GetRandomIntArray(a);

            for (int i = 0; i < mas1.Length; i++)
            {

                for (int j = i + 1; j < mas1.Length; j++)
                {
                    if (mas1[i] > mas1[j])
                    {
                        int tmp = mas1[i];
                        mas1[i] = mas1[j];
                        mas1[j] = tmp;
                    }

                }


            }
            return string.Join(' ', mas1);
        }

        public static int[] AddElementToBeginingArray(int[] array, int a)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[0] = a;

            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
            
        }

        public static int[] AddElementInTheEndArray(int[] array, int a)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[newArray.Length - 1] = a;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }   

            return newArray;

        }

        public static int[] AddElementToTheMiddleArray(int[] array, int a)
        {
            int[] newArray = new int[array.Length + 1];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == newArray.Length / 2)
                {
                    newArray[j] = a;
                    newArray[j + 1] = array[i];
                    j++;

                }

                else newArray[j] = array[i];
                j++;
            }

            return newArray;

        }

        public static void AddElementToTheIndexInArray(ref int[] array, int a, int index)
        {
            int[] newArray = new int[array.Length + 1];
            

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index  - 1)
                {
                    newArray[j] = a;
                    newArray[j + 1] = array[i];
                    j++;

                }

                else newArray[j] = array[i];
                j++;
            }

            array = newArray;

        }


    }
}
