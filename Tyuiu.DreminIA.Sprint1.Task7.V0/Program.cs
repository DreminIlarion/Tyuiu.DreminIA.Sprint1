using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIA.Sprint1.Task7.V0.Lib;



namespace Tyuiu.DreminIA.Sprint1.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значения x и y:");

            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = Math.Exp(x) - (Math.Pow(y, 2) + 6 + Math.Cos(Math.Pow(x, 3)) + x * y - 2 * Math.Pow(x, 2)) /
                       (Math.Sin(Math.Pow(x, 4) + 13) + 9 * y - 2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Ответ: {z:F3}");

        }
    }
}
