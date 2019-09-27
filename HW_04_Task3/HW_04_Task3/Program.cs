using System;

namespace HW_04_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1000, value = 0;
            for (int i = 1; i <= 12; i++)
            {
                value = (money * 2) / 100 + value;
                money += value;
                value = Math.Truncate(value * 100) / 100;
                money = Math.Truncate(money * 100) / 100;
                if (i <= 10)
                    Console.WriteLine("{0,0}",value);
                if (i >= 3 && i <= 12)
                    Console.WriteLine("{0,50}",money);
                
            }
        }
    }
}
