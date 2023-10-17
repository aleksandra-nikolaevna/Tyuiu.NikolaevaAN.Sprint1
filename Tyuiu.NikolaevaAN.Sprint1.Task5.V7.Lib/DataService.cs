using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NikolaevaAN.Sprint1.Task5.V0.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double h = f / 30;
            int res = Convert.ToInt32(Math.Truncate(h));
            return res;
        }
    }
}