using System;
using System.Collections.Generic; // Для краткости в коде

namespace MyApp.Utilities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class StringHelper
    {
        public void PrintMessage(string msg)
        {
            // Используем using System; и пользуемся "коротким" именем
            Console.WriteLine(msg);
        }

        public List<string> GetList()
        {
            // Используем using System.Collections.Generic;
            var list = new List<string>();
            list.Add("Hello");
            return list;
        }
    }
}