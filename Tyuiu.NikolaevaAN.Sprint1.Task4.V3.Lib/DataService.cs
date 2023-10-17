using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaevaAN.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V4
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Sqrt(x * 3) / (Math.Pow(x - y, 2));
            return res;
        }
    }
}