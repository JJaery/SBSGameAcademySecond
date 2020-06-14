using System; /// <- 얘 안에는 Console.WriteLine이 들어가 있구나

namespace Name
{
    class Program
    {
        static Person personVar;
        static void Main(string[] args)
        {
            ///셋팅
            Person personA = new Person();
            personA.name = "철수";
            personA.firstName = '김';
            personA.height = 178.1f;
            personA.age = 22;
            personA.isFemale = false;

            // 영미 만들어 보자
            Person personB = new Person();
            personB.firstName = '안';
            personB.name = "영미";
            personB.height = 169.1f;
            personB.age = 32;
            personB.isFemale = true;


            personVar = personA;
            personVar.Say();

            personVar = personB;
            personVar.Say();

            Person personC = new Person();
            Console.WriteLine("성을 입력하세요! 한글자만 : ");
            string input = Console.ReadLine();
            personC.firstName = Convert.ToChar(input);
            Console.WriteLine("이름을 입력하세요! : ");
            input = Console.ReadLine();
            personC.name = input;
            Console.WriteLine("키를 입력하세요 소수점까지!! : ");
            input = Console.ReadLine();
            personC.height = Convert.ToSingle(input);
            Console.WriteLine("나이를 입력하세요 정수만! : ");
            input = Console.ReadLine();
            personC.age = Convert.ToInt32(input);
            Console.WriteLine("여자입니까? (true/false) : ");
            input = Console.ReadLine();
            personC.isFemale = Convert.ToBoolean(input);

            personC.Say();

        }
    }

    class Person
    {
        // 변수 만들기.
        /// -변수형
        /// 정수형 int      - byte short long    -  uint ushort sbyte  ulong
        /// 실수형 float    -  double                                                       decimal
        /// boolen형(논리형) - bool (true or false)
        /// 문자열형 string  
        /// 문자형 - char

        public int age;
        public float height;
        public string name;
        public char firstName;
        public bool isFemale;

        public void Say()
        {
            Console.WriteLine($"나는 {firstName}{name} 이고 {age} 살이고 키는 {height} 이야");



            Console.WriteLine("나는 여자일까 ? : " + isFemale);

        }
    }
}
