using System;

namespace Calculrator
{
    class Program
    {
        //메일 : sbspapa7545@gmail.com
        static void Main(string[] args)
        {
            Calculrator cal = new Calculrator();
            Console.WriteLine("더하기를 할 두 수를 입력 하세요");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(cal.Add(a, b));

            Console.WriteLine("뺄 두 수를 입력 하세요");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(cal.Minus(a, b));

            Console.WriteLine("곱할 두 수를 입력 하세요");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(cal.Multiply(a, b));

            Console.WriteLine("나눌 두 수를 입력 하세요");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(cal.Division(a, b));

            Console.WriteLine("나머지 연산할 두 수를 입력 하세요");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine(cal.MOD(a, b));
        }
    }

    class Calculrator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
        public int MOD(int a, int b)
        {
            return a % b;
        }

    }
}
