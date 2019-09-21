using System;

namespace hw_02_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";
            int x = 30;
            char symb = 'H';
            Console.WriteLine(word + " " + x + " " + symb);
            Console.WriteLine("----------------------");
            var world = "World!";
            var y = 30;
            var Symb = 'F';
            Console.WriteLine(world+" "+y+" "+Symb);
            Console.WriteLine("----------------------");
            string day = "Good Morning!";
            object o = day;
            object c = (string) o;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
