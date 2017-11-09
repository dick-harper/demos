using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Welcome to Demo.Console.\nCurrent date is {DateTime.Now}.\nPress <any> key to exit");

            System.Console.ReadKey();
        }
    }
}
