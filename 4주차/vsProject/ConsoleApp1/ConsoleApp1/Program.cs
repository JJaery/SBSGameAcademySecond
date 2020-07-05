using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            while (str != "q")
            {
                Console.WriteLine("로또번호 생성기. 생성하려면 아무키나 누르시오. 종료하려면 'q'를 입력하시오");
                str = Console.ReadLine();
                HashSet<int> _hashSet = new HashSet<int>();
       
                Random random = new Random();
                for (int i = 0; i < 6;)
                {
                    int randomI = random.Next(1, 46);
                    if (_hashSet.Add(randomI) == true)
                    {
                        i++;
                    }
                }
                foreach (int item in _hashSet)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
