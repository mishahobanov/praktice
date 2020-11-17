using System;

namespace praktice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 5;

            var wynik1 = a % b % c;

            Console.WriteLine("______zad1____");

            Console.WriteLine("wynik{0}", wynik1);

            Console.WriteLine("______zad2______");

            int x;
            x = 256;
            var wynik2 = x >> 2;
            var wynik3 = x << 2;


            Console.WriteLine("wynik {0} {1}", wynik2, wynik3);

            Console.WriteLine("______zad3______");

            int i = 20, y = 10;

            var wynik4 = i & y;
            var wynik5 = i | y;
            Console.WriteLine("wynik {0} {1}", wynik4, wynik5);

            Console.WriteLine("______zad4______");
            int w = 10;
            var wynik6 = w ^ 20;
            w ^= 20;
            Console.WriteLine("wynik {0} ", w);

            Console.WriteLine("______zad5______");
            int z = 1;

            var sposob1 = z ^ 2;

            var sposob2 = z | 3;

            var sposob3 = (z << 1)|3  ;

            Console.WriteLine("sposob1 = {0} sposob2 = {1} sposob3 = {2}", sposob1, sposob2, sposob3);

            Console.WriteLine("______zad6______");
            int e=3,t = 1;

            e = e - t-t;

            t = e+t+t;

            Console.WriteLine("wynik1 = {0} wynik2 = {1}", e, t);



        }
    }
}
