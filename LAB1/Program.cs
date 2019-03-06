using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program {

        public static void squaringQuontientOfTwoRealNumbers(double fstNum,double sndNum)
        {
            double temp;
            temp = fstNum / sndNum;
            Console.WriteLine("({0} / {1})^2 = " + Math.Pow(temp, 2),fstNum,sndNum);

        }
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите два любых вещественных числа: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            squaringQuontientOfTwoRealNumbers(x, y);
            
        }
    }
}
