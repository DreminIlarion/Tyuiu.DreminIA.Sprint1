using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task1.V0.Lib
{
    public class DataService : ISprint1Task1V26
    {
        public double Calculate(double x, double y)
        {
            return 5 * x / (2 + y);
        }
    }
}
