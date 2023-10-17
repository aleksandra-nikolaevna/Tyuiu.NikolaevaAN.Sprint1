using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaevaAN.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            int n = Convert.ToInt32(number);
            int n1, n2, n3;
            n1 = n / 100;
            n2 = (n / 10) % 10;
            n3 = n % 10;
            return n1 * n2 * n3;
        }
    }
}