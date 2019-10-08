using System;

namespace HW_06_Task2
{
    class Program
    {
        static char[] replaceMethod(char[] txt)
        {
            int lenght = txt.Length;
            int value = 0;
            int space = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsPunctuation(txt[i]))
                {
                    txt[i] = '\0';
                    value++;
                }
                if (char.IsWhiteSpace(txt[i]))
                    space++;
            }
            Console.WriteLine();
            Console.WriteLine($"Количество пунктуационных знаков: {value}");
            Console.WriteLine($"Количество букв :{lenght-value-space}");
            return txt;
        }
        static string[] deleteLongestWord(string[] array)
        {
            Console.WriteLine();
            int size = array.Length;
            string[] deletedWordArray = new string[size - 1];
            Console.WriteLine("Массив после удаления самого длинного слова:");
            for (int i = 0; i < deletedWordArray.Length; i++)
            {
                deletedWordArray[i] = array[i + 1];
                Console.WriteLine(deletedWordArray[i]);
            }
            return deletedWordArray;
        }
        static string[] sortArray(string text)
        {
            Console.WriteLine();
            string[] array = text.Split(new char[] { ' ' });
            Console.WriteLine("Неотсортированный массив:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }         
            string value;
            for(int i = 0; i < array.Length-1;i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[j].Length) > array[i].Length)
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return array;
        }
        static void replaceWords(string[] txt)
        {
            Console.WriteLine();
            Console.WriteLine("Произведена рокировка самого длинного слова с самым маленьким:");
            string temp;
            temp = txt[0];
            txt[0] = txt[txt.Length - 1];
            txt[txt.Length - 1] = temp;
            for(int i=0;i<txt.Length;i++)
                Console.WriteLine(txt[i]);
        }
                
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            char[] symbs = Console.ReadLine().ToCharArray();
            char[] fix = replaceMethod(symbs);
            string txt = new string(fix);
            string[] stringArray1 = sortArray(txt);
            string[] deleteLongestWord1 = deleteLongestWord(stringArray1);
            replaceWords(stringArray1);
        }
    }
}
