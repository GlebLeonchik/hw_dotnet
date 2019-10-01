using System;

namespace HW_03_Task1
{
    class Program
    {
        static int calc()
        {
            Console.WriteLine("Введите первое слагаемое:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int amount = num1 + num2;
            Console.WriteLine("Сумма чисел равна " + amount);
            return amount;
        }
        static void Main(string[] args)
        {
            calc();
            Console.ReadKey();
        }
    }
}
