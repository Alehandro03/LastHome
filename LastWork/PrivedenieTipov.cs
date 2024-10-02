using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class PrivedenieTipov
    {       

        public static int SumOfThreeDigitConstNumber(int a)
        {
            int a1,a2,a3;
            if (a > 999) throw new ArgumentOutOfRangeException("Число больше");
            else if(a<100) throw new ArgumentOutOfRangeException("Число меньше");
            else
            {
                a1 = a / 100;
                a2 = (a % 100) / 10;
                a3 = a % 10;
                return a1 + a2 + a3;
            }
                
        }

        public static string GetResultShot(int x, int y)
        {
            bool hit = true;
         
            double d = Math.Pow(5, 2) + Math.Pow(5, 2);

            if (hit == d > Math.Pow(x, 2) + Math.Pow(y, 2)) return "Есть поподание!";

            else return "Мимо";

        }

        public static bool GetResultConditionThreeDigitConstNumber(int a)
        {
            if (a < 100 || a > 999) throw new ArgumentOutOfRangeException("Значение не трехзначное!");
            else
            {
                int a1, a2, a3;

                bool res = true;

                a1 = a / 100;
                a2 = (a % 100) / 10;
                a3 = a % 10;

                res = a1 >= a2 && a2 > a3 ? true : false;

                return res;
            }          

            //if (a1 >= a2 && a2 > a3) return res; 

            //else
            //{
            //    res = false;

            //    return res;
            //}
       
        }

        public static int GetNewThreeDigitNumber(int a)
        {
            if (a < 100 || a > 999) throw new ArgumentOutOfRangeException("Значение не трехзначное!");
            else
            {
                int a1, a2, a3;

                a1 = a / 100;
                a2 = (a % 100) / 10;
                a3 = a % 10;

                return (a3 * 100) + (a2 * 10) + a1;
            }
         
        }

        public static bool GetResultExaminationRemainder(double a)
        {
            bool res = true;

            if (a == (int)a) return res;
            else
            {
                res = false;
                return res;
            }
        }



    }
}
