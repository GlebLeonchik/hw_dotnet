using System;

namespace HW_03_Task2
{
    class Program
    {
        static void calc()
        {
            Console.WriteLine("Введите первое слагаемое:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int amount = num1 + num2;
            Console.WriteLine("Введите сумму этих слагаемых: ");
            int check = Convert.ToInt32(Console.ReadLine());
            if (check == amount)
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильно!");
            }
        }
        static void Main(string[] args)
        {
            calc();
            Console.ReadKey();
        }
    }
}
