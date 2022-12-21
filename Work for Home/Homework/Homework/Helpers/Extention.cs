using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Helpers
{
    public static class Extention
    {
        //public static int Factorial(this int n)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result = result * i;
        //    }
        //    return result;
        //}

        public static double GetNumPower(this int number, int power)
        {
            var result=Math.Pow(number, power);

            return result;



        }
    }
}
