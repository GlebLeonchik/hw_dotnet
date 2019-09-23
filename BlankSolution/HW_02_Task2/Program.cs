using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a1 = -2147483648;
            int a2 = 2147483647;
            Console.WriteLine(a1 + "    " + a1.GetType());
            Console.WriteLine(a2 + "    " + a2.GetType());
            bool b1 = true;
            Boolean b2 = false;
            Console.WriteLine(b1 + "    " + b1.GetType());
            Console.WriteLine(b2 + "    " + b2.GetType());
            byte c1 = 1;
            Byte c2 = 255;
            Console.WriteLine(c1 + "    " + c1.GetType());
            Console.WriteLine(c2 + "    " + c2.GetType());
            sbyte d1 = -128;
            SByte d2 = 127;
            Console.WriteLine(d1 + "    " + d1.GetType());
            Console.WriteLine(d2 + "    " + d2.GetType());
            char e1 = '\u0041';
            Char e2 = '\u0042';
            Console.WriteLine(e1 + "    " + e1.GetType());
            Console.WriteLine(e2 + "    " + e2.GetType());
            decimal f1 = 15;
            Decimal f2 = 13;
            Console.WriteLine(f1 + "    " + f1.GetType());
            Console.WriteLine(f2 + "    " + f2.GetType());
            double g1 = 5.3;
            Double g2 = 7.1;
            Console.WriteLine(g1 + "    " + g1.GetType());
            Console.WriteLine(g2 + "    " + g2.GetType());
            float h1 = 17;
            Single h2 = 19;
            Console.WriteLine(h1 + "    " + h1.GetType());
            Console.WriteLine(h2 + "    " + h2.GetType());
            uint i1 = 22;
            UInt32 i2 = 55;
            Console.WriteLine(i1 + "    " + i1.GetType());
            Console.WriteLine(i2 + "    " + i2.GetType());
            long j1 = 822;
            Int64 j2 = 823;
            Console.WriteLine(j1 + "    " + j1.GetType());
            Console.WriteLine(j2 + "    " + j2.GetType());
            ulong k1 = 555;
            UInt64 k2 = 556;
            Console.WriteLine(k1 + "    " + k1.GetType());
            Console.WriteLine(k2 + "    " + k2.GetType());
            object [] l1 = { 1, 2, 3 };
            Object [] l2 = { 4, 5, 6 };
            Console.WriteLine(l1 + "    " + l1.GetType());
            Console.WriteLine(l2 + "    " + l2.GetType());
            short m1 = 10;
            Int16 m2 = 9;
            Console.WriteLine(m1 + "    " + m1.GetType());
            Console.WriteLine(m2 + "    " + m2.GetType());
            ushort o1 = 3;
            UInt16 o2 = 2;
            Console.WriteLine(o1 + "    " + o1.GetType());
            Console.WriteLine(o2 + "    " + o2.GetType());
            string p1 = "Добро";
            String p2 = "пожаловать";
            Console.WriteLine(p1 + "    " + p1.GetType());
            Console.WriteLine(p2 + "    " + p2.GetType());
            Console.ReadKey();

        }
    }
}