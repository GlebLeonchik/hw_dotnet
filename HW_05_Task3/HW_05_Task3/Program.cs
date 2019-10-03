using System;

namespace HW_05_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Random rnd = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 51);
                Console.Write("| "+array[i]+" ");
            }
            Console.WriteLine("|");
            Console.WriteLine();
            for(int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (i < j)
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                    
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("| "+array[i]+" ");
            }
            Console.WriteLine("|");
        }

    }
}
