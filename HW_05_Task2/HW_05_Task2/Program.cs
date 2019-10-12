using System;

namespace HW_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index, value, Ind, Val;
            int[] muss = new int[10];
            for(int i = 0; i < muss.Length - 1; i++)
            {
                Console.WriteLine("Введите "+i+" элемент массива");
                muss[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i = 0; i < muss.Length; i++)
            {
                Console.Write("| " + muss[i] + " ");
            }
            Console.WriteLine("|");
            Console.WriteLine();
            Console.WriteLine("Введите значение элемента массива:");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите его индекс:");
            index = Convert.ToInt32(Console.ReadLine());
            Ind = index;
            Console.WriteLine();
            for(int i = 0; i < muss.Length; i++)
            {
                if (i == Ind)
                {
                    Val = muss[i];
                    Ind = i + 1;
                    muss[i] = value;
                    value = Val;
                }
            }
            for (int i = 0; i < muss.Length; i++)
            {
                Console.Write("| "+muss[i]+" ");
            }
            Console.WriteLine("|");
        }
    }
}
