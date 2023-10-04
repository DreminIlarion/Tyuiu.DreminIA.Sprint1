using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DreminIA.Sprint1.Task6.V0.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string ModifyWord(string word)
        {
            return word.Substring(1) + word[0];
        }
    }
}
