using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = "";
            while (inputMessage != "q")
            {
                inputMessage = Console.ReadLine();
                Console.WriteLine(inputMessage);
            }
        }
    }
}
