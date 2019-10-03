using System;

namespace HW_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] numRandom = new int[size];
            int[] numInput = new int[size];
            int[] numSumm = new int[size];
            Random rdn = new Random();
            for(int i = 0; i < numRandom.Length; i++)
            {
                numRandom[i] = rdn.Next(1, 11);
            }
            Console.WriteLine();
            
            for(int i = 0; i < numInput.Length; i++)
            {
                Console.WriteLine("Введите "+i+"-е число массива:");
                numInput[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i = 0; i < numSumm.Length; i++)
            {
                numSumm[i] = numRandom[i] + numInput[i];
            }
            Console.WriteLine();
            Console.WriteLine("Random \tInput \tAmount");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}",numRandom[i],numInput[i],numSumm[i]);

            }
        }
    }
}
