using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            //auto a = new auto(15);
            //auto b = new auto("Hello");
            //auto c = new auto(7.8);
            //auto d = new auto("50");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            //b = a + d;
            //Console.WriteLine(b);
            //if (a == b)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            //auto a = new auto(10), b = new auto("120"), c;
            //c = a + b;
            //Console.WriteLine(c); // Выведет 130
            //c = b + a;
            //Console.WriteLine(c); // Выведет “12010”

            //auto a = new auto("Microsoft"), b = new auto("Windows"), c;
            //c = a * b;
            //Console.WriteLine(c); // Выведет “ioso”

            auto a = new auto("Microsoft"), b = new auto("Windows"), c;
            c = a / b;
            Console.WriteLine(c); // Выведет “Mcrft”

            auto test1 = new auto("Microsoft");
            auto test2 = new auto(15);
            Console.WriteLine(test1 == test2);
            Console.WriteLine(test1.Equals(test2));
            Console.WriteLine(test1.GetHashCode());
            Console.WriteLine(test2.GetHashCode());

        }
    }
}
