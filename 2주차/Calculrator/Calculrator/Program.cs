using System;
using Home;
using HomeMesdasdsad = Home.Me;

namespace Calculrator
{
    class Program
    {
        static void Main()
        {
            Person a = new Person();
            Person b = new Person();
            a.name = "인재";
            b.name = "영미";
            //a == 인재, b == 영미

            b = a;
            //a == 인재, b == 인재

            b.name = "영미";
            //a == 영미, b == 영미
            Console.WriteLine($"{a.name} - {b.name}");

        }
    }

    class Person
    {
        public string name;
    }


}
