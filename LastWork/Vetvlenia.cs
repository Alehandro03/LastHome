using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class Vetvlenia
    {

        public static int GetAnswerComputations(int a, int b)
        {
            if (a > b) return a + b;
            else if (a == b) return a * b;
            else return a - b;
        }

        public static int GetResultQuarter(int x, int y)
        {
            if (x >= 0 && y >= 0) return 1;
            else if (x < 0 && y >= 0) return 2;
            else if (x < 0 && y < 0) return 3;
            else return 4;
        }

        public static string GetNumbersAscending(int a, int b, int c)
        {
            string res;

            //if (a > b && b > c) return ($"Ответ {c} < {b} < {a}");
            //if (a > c && b < c) return ($"Ответ {b} < {c} < {a}");
            //if (a < c && b > c) return ($"Ответ {a} < {c} < {b}");
            //if (c > b && b > a) return ($"Ответ {a} < {b} < {c}");
            //if (b > a && a > c) return ($"Ответ {c} < {a} < {b}");
            //if (c > a && a > b) return ($"Ответ {b} < {a} < {c}");

            res = a > b && b > c ? $"Ответ {c} < {b} < {a}" :
                (a > c && b < c) ? $"Ответ {b} < {c} < {a}" :
                (a < c && b > c) ? $"Ответ {a} < {c} < {b}" :
                (c > b && b > a) ? $"Ответ {a} < {b} < {c}" :
                (b > a && a > c) ? $"Ответ {c} < {a} < {b}" : 
                (b == a && b == c) ? "Числа равны":
                $"Ответ {b} < {a} < {c}";

            return res;

        }

        public static string GetWrittenNumber(int a)
        {
            
            string res;
                     
            if(a < 0 || a >= 100) throw new ArgumentException("не соответствует условиям!");
            else if (a == 0 ||a >= 10 && a < 20)
            {
                switch (a)
                {
                    case 0:  res = "ноль"; break;
                    case 10: res = "десять"; break;
                    case 11: res = "одиннадцать"; break;
                    case 12: res = "двенадцать"; break;
                    case 13: res = "тринадцать"; break;
                    case 14: res = "четырнадцать"; break;
                    case 15: res = "пятнадцать"; break;
                    case 16: res = "шестнадцать"; break;
                    case 17: res = "семнадцать"; break;
                    case 18: res = "восемнадцать"; break;
                    case 19: res = "девятнадцать"; break;
                    default: res = "неверное число"; break;

                }

            }
            else 
            {
                int b, c;
                string b1, c1;

                c = (a / 10) * 10;
                b = a % 10;
                switch (b)
                {
                    
                    case 1: b1 = "один"; break;
                    case 2: b1 = "два"; break;
                    case 3: b1 = "три"; break;
                    case 4: b1 = "четыре"; break;
                    case 5: b1 = "пять"; break;
                    case 6: b1 = "шесть"; break;
                    case 7: b1 = "семь"; break;
                    case 8: b1 = "восемь"; break;
                    case 9: b1 = "девять"; break;
                    default: b1 = ""; break;
                }

                switch (c)
                {
                    
                    case 20: c1 = "двадцать"; break;
                    case 30: c1 = "тридцать"; break;
                    case 40: c1 = "сорок"; break;
                    case 50: c1 = "пятьдесят"; break;
                    case 60: c1 = "шестьдесят"; break;
                    case 70: c1 = "семьдесят"; break;
                    case 80: c1 = "восемьдесят"; break;
                    case 90: c1 = "девяносто"; break;
                    default: c1 = ""; break;
                }

                res = c1 + " " + b1;

            }

            return res;

        }

        public static string GetAnswerExistsTriangle(int a, int b, int c)
        {           

            return  a + b > c && c + b > a && a + c > b ? "Существует" : "Не существует";
        }



    }
}
