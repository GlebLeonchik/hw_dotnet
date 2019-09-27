using System;

namespace HW_04_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =90; i >= 65; i--)
            {
                char symb = Convert.ToChar(i);
                Console.Write("| "+symb+" ");
            }
            Console.WriteLine("|");
        }
    }
}
