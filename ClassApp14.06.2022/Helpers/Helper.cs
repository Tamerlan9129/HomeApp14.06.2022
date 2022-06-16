using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp14._06._2022.Helpers
{
    class Helper
    {
        public static void Printer(string text, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
           
        }
    }
}
