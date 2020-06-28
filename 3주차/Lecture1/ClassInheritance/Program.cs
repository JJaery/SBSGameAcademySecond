using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

    }

    class Creature
    {
        public int lifeTime;
        public string DNA;

        public void Breath()
        {
            lifeTime = lifeTime + 1;
            Console.WriteLine(lifeTime);
        }

    }

    class Human : Creature, iTwoWalker
    {
        public string Language;

        public void 이족보행()
        {

        }
    }
    class 타조 : iTwoWalker
    {
        public void 이족보행()
        {

        }
    }

    class Animal : Creature
    {
        public string Roar;
    }

    interface iTwoWalker
    {
        void 이족보행();
    }
}
