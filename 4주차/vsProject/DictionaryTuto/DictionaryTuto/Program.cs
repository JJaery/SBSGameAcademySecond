using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> _dic = new Dictionary<string, int>();
            _dic.Add("가", 1);
            _dic.Add("나", 2);
            _dic.Add("다", 3);

            foreach (string item in _dic.Keys)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
