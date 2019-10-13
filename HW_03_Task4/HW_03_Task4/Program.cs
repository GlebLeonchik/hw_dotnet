using System;

namespace HW_03_Task4
{
    class Program
    {
        static void calc()
        {
            Console.WriteLine("Введите первое слагаемое:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак + или -");
            string sigh = Console.ReadLine();
            if (sigh == "+")
            {
                int amount = num1 + num2;
                Console.WriteLine("Введите сумму этих слагаемых: ");
                int check = Convert.ToInt32(Console.ReadLine());
                if (check == amount)
                {
                    Console.WriteLine("Правильно!");
                }
                else if (check != amount && check > amount)
                {
                    Console.WriteLine("Неправильно, ожидается число поменьше!");
                }
                else if (check != amount && check < amount)
                {
                    Console.WriteLine("Неправильно, ожидается число побольше!");
                }
            }
            else if (sigh == "-")
            {
                int amount = num1 - num2;
                Console.WriteLine("Введите сумму этих слагаемых: ");
                int check = Convert.ToInt32(Console.ReadLine());
                if (check == amount)
                {
                    Console.WriteLine("Правильно!");
                }
                else if (check != amount && check > amount)
                {
                    Console.WriteLine("Неправильно, ожидается число поменьше!");
                }
                else if (check != amount && check < amount)
                {
                    Console.WriteLine("Неправильно, ожидается число побольше!");
                }

            }
            else
                Console.WriteLine("Введён неверный знак!");
        }
        static void Main(string[] args)
        {
            calc();
            Console.ReadKey();
        }
    }
}
