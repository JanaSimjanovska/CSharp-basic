using System;

namespace Semafor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                  *  *    ");
            Console.WriteLine("               *        * ");
            Console.WriteLine("              *          *");
            Console.WriteLine("Stop!         *          *");
            Console.WriteLine("               *        * ");
            Console.WriteLine("                  *  *    ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                  *  *    ");
            Console.WriteLine("               *        * ");
            Console.WriteLine("              *          *");
            Console.WriteLine("Get ready!    *          *");
            Console.WriteLine("               *        * ");
            Console.WriteLine("                  *  *    ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                  *  *    ");
            Console.WriteLine("               *        * ");
            Console.WriteLine("              *          *");
            Console.WriteLine("Go!           *          *");
            Console.WriteLine("               *        * ");
            Console.WriteLine("                  *  *    ");

            Console.ReadLine();
        }
    }
}
