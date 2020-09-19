using System;
using FirstLib;

namespace FirstcoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Choice");
            int ch = System.Convert.ToInt32(System.Console.ReadLine());
            Arithmetic a  = ArithmeticFactory.getFactory(ch);
            a.read();
            a.calculate();
            a.display();
        }
    }
}
