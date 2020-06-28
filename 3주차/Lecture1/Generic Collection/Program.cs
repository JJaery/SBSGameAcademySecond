using System;
using System.Collections.Generic;

namespace Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> _list = new List<int>();
            //_list.Add(101020);
            //_list.Add(1010);
            //_list.Add(100);
            //_list.Add(120);

            //_list.Remove(100);

            //_list.Clear();

            //for(int i = 0; i < _list.Count; i ++)
            //{
            //    Console.WriteLine(_list[i]);
            //}



            //Dictionary<string, string> _dic = new Dictionary<string, string>();
            //_dic["사과"] = "빨갛고 사과나무에서 열리는 열매이다.";
            //_dic["배"] = "노랗고 배나무에서 열리는 열매이다.";

            //if (_dic.ContainsKey("사과"))
            //{
            //    Console.WriteLine("사전에 사과가 있습니다.");
            //}

            ////_dic.Remove("사과");

            ////_dic.Clear();

            //foreach (string sub in _dic.Keys)
            //{
            //    Console.WriteLine($"{sub} : {_dic[sub]}");
            //}


            //Queue<int> _queue = new Queue<int>();
            //_queue.Enqueue(10);
            //_queue.Enqueue(20);
            //_queue.Enqueue(30);

            //Console.WriteLine(_queue.Peek());
            //Console.WriteLine(_queue.Dequeue());
            //Console.WriteLine(_queue.Dequeue());
            //Console.WriteLine(_queue.Dequeue());

            Stack<int> _stack = new Stack<int>();
            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            Console.WriteLine(_stack.Peek());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
        }
    }
}
