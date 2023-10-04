using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.DreminIA.Sprint1.Task4.V0.Lib;


namespace Tyuiu.DreminIA.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение угла alpha:");
            double alpha = double.Parse(Console.ReadLine());

            double result = MyLib.Calculator.CalculateResult(alpha);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат: {result}");
        }
    }
}
