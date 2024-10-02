using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class Cycle
    {
        public static List<int> GetNumberDivideOnA(int a)

        {
            int count = 0;

            List<int> values = new List<int>();

            while (count < 1000)
            {
                count++;

                if (0 == count % a) values.Add(count);

            }
            return values;
        }

        public static int CountSquareIsSmaller(int a)
        {
            int count = 1;
            int temp = 0;

            while(Math.Pow(count,2)<a)
            {
                temp++;
                count++;
            }
             
            return temp;
        }

        public static int GetBigDivider(int a)
        {
            int res = 0;

            for(int i = 1; i < a; i++)
            {
                if (0 == a % i) res = i;
            }
                                
            return res;
        }

        public static int SumAllNumberInDiapozonDivideOnSeven(int a, int b)
        {
            int count = 0;

            if(a > b)
            {
                int tmp = 0;

                tmp = a;
                a = b;
                b = tmp;
            }

            for(int i = a; i < b; i++ )
            {
                if(0 == i % 7) count = count + i;

            }

            return count;
        }

        public static int BindBigGenetalDevideEuclid(int a, int b)
        {
            if (a == 0 && b == 0) throw new ArgumentException("Числа равны нулю!");// разобрать на ютубе

            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return  a + b;
        }


        public static int FindNumberMetodHalfDivision(int a)
        {
            if (a == 0) throw new ArgumentException("Заданное число равно 0!");
            int left = 0;
            int right = a;
            int middle = -2;

            while (left + 1 != right - 1)
            {
                middle = (left + right) / 2;
                if (Math.Pow(middle, 3) == a) return middle;
                else if (Math.Pow(middle, 3) > a) right = middle;
                else if (Math.Pow(middle, 3) < a) left = middle;

            }
            return middle;
        }

        public static int FindCountOddNumber(int a)
        {

            int countOddNumber = 0;
     
            while(a != 0)
            {              

                int lastNumber = 0;

                lastNumber = a % 10;

                if(lastNumber % 2 != 0) countOddNumber++;

                a /= 10;

            }
            return countOddNumber;
    
        }


        public static int ReversNumber(int number)
        {
            int reversNumber = 0;

            //int L = number.ToString().Length;

            while (number != 0)
            {
                reversNumber += number % 10;

                reversNumber *= 10;

                number /= 10;

            }

            return reversNumber /= 10;

        }

        public static bool GetResultatComparisonTwoNumber(int a, int b)
        {
            int lengthA = a.ToString().Length;

            int lengthB = b.ToString().Length;

            int lastNumberA = 0;

            int lastNumberB = 0;

            int newA = a;

            bool res;

            for(int i = 0; i < lengthB; i++ )
            {

                lastNumberB = b % 10;

                b /= 10;


                for(int j = 0; j < lengthA; j++)
                {

                   lastNumberA = newA % 10;

                    if (lastNumberA == lastNumberB)
                    {
                       return res = true;

                        break;
                    }

                    newA /= 10;

                }

                newA = a;
            }

            return false;


        }



    }



    
}
