using System;
using Newtonsoft.Json.Linq;

namespace Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var json = @"{
                CPU: 'Intel',
                Drives: [
                'DVD read/writer',
                '500 gigabyte hard drive']}";

            var o = JObject.Parse(json); 

            System.Console.WriteLine($"Welcome to Demo.Console.\nCurrent date is {DateTime.Now}.\nInventory (json):\n{o}\nPress <any> key to exit");

            System.Console.ReadKey();
        }
    }
}
