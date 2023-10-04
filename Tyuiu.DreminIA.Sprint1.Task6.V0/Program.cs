using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DreminIA.Sprint1.Task6.V0.Lib;



namespace Tyuiu.DreminIA.Sprint1.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();
            string[] words = inputText.Split(' ');

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            foreach (string word in words)
            {
                string modifiedWord = word.Substring(1) + word[0];
                Console.WriteLine(modifiedWord);
            }

            Console.ReadLine();

        }
    }
}
