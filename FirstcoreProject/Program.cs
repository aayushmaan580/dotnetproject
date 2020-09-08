using System;
using FirstLib;

namespace FirstcoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("New line");
            var obj = new FirstLib.Addition();
            Console.WriteLine(obj.display());
        }
    }
}
