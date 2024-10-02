using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastWork
{
    public class Peremenye
    {
        public static double GetSum(double a, double b)
        {
            return a + b;
        }

        public static int GetSum(int a, int b)
        {
            return a + b;
        }

        public static double GetResultEquation(int a, int b)
        {
            if((5 * a + Math.Pow(b, 4)) == 0) throw new DivideByZeroException("Числитель равен нулю!");

            return (5 * a + Math.Pow(b,4)) / (b - a);
        }

        public static string SwapsString(string a, string b)
        {   
            if(a!=b)
            {
                string c = a;
                a = b;
                b = c;
            }
            else throw new ArgumentException("Одинаковые значения!");

            return ($"{a},{b}") ;

        }

        public static double GetAnswerLinearEquation(int a, int b, int c)
        {
  
            //if (a != 0 && b != 0 && c != 0) return c / a - b;
            
            //else throw new ArgumentNullException("Одно из значений имеет 0");

            // Или условным выражением.
            
            return a != 0 && b != 0 && c != 0 ? c / a - b : throw new ArgumentNullException("Одно из значений имеет 0");
        }

        public static string GetAnswerQuadraticEquation(int a, int b, int c)
        {
            double x1, x2, d;

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;

                x2 = (-b - Math.Sqrt(d)) / 2 * a;

                return $"Два корня: {x1}, {x2}";
            }
            else if (d == 0) return $"Один корень:{(-b + Math.Sqrt(d)) / 2 * a}";
            else return "Корней нет";

        }































    }
}
