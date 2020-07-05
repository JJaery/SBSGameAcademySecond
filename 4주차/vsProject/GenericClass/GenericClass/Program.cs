using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Test<int,string> test = new Test<int,string>();
            Console.WriteLine(test.TestFunc(1232910));
        }
    }

    class Test<T,T2>
    {
        public T item;
        public T[] itemArray;
        public List<T> itemCollection;

        public T TestFunc(T i)
        {
            return i;
        }
    }
}
