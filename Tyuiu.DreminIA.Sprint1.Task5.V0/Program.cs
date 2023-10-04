using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIA.Sprint1.Task5.V0.Lib;


namespace Tyuiu.DreminIA.Sprint1.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение угла (0<f<360): ");
            double angle = double.Parse(Console.ReadLine());

            double hours = ClockLib.ClockCalculator.CalculateHours(angle);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Прошло {hours} часов с начала суток.");
        }
    }
}
