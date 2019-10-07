using System;

namespace HW_04_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Куда необходимо переместиться?");
            char symb =Convert.ToChar(Console.ReadLine());
            string txt;
            switch (symb)
            {
                case 'w':
                case 'W':
                    txt = "Сделан шаг вперед!";
                    Console.WriteLine(txt);
                    break;
                case 's':
                case 'S':
                    txt = "Сделан шаг назад!";
                    Console.WriteLine(txt);
                    break;
                case 'a':
                case 'A':
                    txt = "Сделан шаг влево!";
                    Console.WriteLine(txt);
                    break;
                case 'd':
                case 'D':
                    txt = "Сделан шаг вправо!";
                    Console.WriteLine(txt);
                    break;
                default:
                    txt = "Шаг не сделан!";
                    Console.WriteLine(txt);
                    break;
            }
        }
    }
}
