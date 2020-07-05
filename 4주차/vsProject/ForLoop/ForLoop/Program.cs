using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
















namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /// for문은 3가지 영역이 있다.
            /// 1. 변수 선언 영역 - int i = 0;
            /// 2. 조건 영역 - i < 10;
            /// 3. 후처리 영역 - i++;
            /// for문 구동 순서
            /// 1 -> 2 -> 내용실행 -> 3 -> 2 -> 내용실행 ...
            for(int i = 0; i < 10; i = i+2) {  }

            int j = 0;
            for(; j < 10; j++ ) { }

            for(; ; j++ ) 
            {
                if (j > 10)
                {
                    break;
                }

                if(j == 11)
                {
                    Console.WriteLine("11번 기능수행");
                    continue; // 밑에 내용 실행 안함
                }

                Console.WriteLine("기능수행");
            }

            for(; ;) { }
        }
    }
}
