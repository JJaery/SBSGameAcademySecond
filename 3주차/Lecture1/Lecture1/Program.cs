
using System;
namespace Lecture1
{

    class Program
    {
        static void Main(string[] args)
        {
            Character charA = new Character();
            Character charB = new Character();

            charA.Hit(charB);
            charB.Hit(charA);
        }
    }

    class Character
    {
        public int hp = 100;
        public int dmg = 5;

        /// 공격하는 메소드
        public void Hit(Character target)
        {
            target.Hitted(this.dmg);
        }

        /// 공격받을 때 호출되는 메소드
        public void Hitted(int targetDmg)
        {
            hp = hp - targetDmg;
            Console.WriteLine($"남은 HP - {hp}");
        }
    }



}
