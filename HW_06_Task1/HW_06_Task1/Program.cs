using System;
using System.Text.RegularExpressions;

namespace HW_06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение, разделяя строки символом \";\"") ;
            string txt = Console.ReadLine();
            txt = Regex.Replace(txt,"а", "О",RegexOptions.IgnoreCase) ;
            txt = Regex.Replace(txt, "a", "O", RegexOptions.IgnoreCase);
            string[] array = txt.Split(new char[] { ';' });
            for(int i=0;i<array.Length;i++)
                Console.WriteLine(array[i]);
            Console.ReadKey();
        }
    }
}
