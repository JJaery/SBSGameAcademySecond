using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 10;

            if(hp > 90)
            {
                Console.WriteLine("정답입니다.");
            }
            else if(hp > 50)
            {
                Console.WriteLine("99 정답입니다.");
            }
            else
            {
                Console.WriteLine("정답에 해당되는 사항이 없네요.");
            }
        }
    }
}
