internal class Program
{
    //    문제)
    //    당신은 동물원 시스템을 만들고 있는 개발자입니다.
    //    동물들은 공통적으로 이름을 가지고 있으며, 각자 고유한 울음소리를 냅니다.
    //    부모 클래스 Animal은 추상 클래스이며, 모든 동물은 이 클래스를 상속받아야 합니다.

    //    구현 조건


    //추상 클래스 Animal을 만드세요.
    //string Name 필드를 가짐
    //생성자에서 "안녕하세요, 저는 [이름]입니다" 출력
    //abstract void MakeSound(); 추상 메서드를 선언
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"안녕하세요, 저는 {name}입니다");
        }
        public abstract void MakeSound();

    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) :  base (name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("냐옹~");
        }
    }
    class Cow : Animal
    {
        public Cow(string name) : base (name)
        {
            
        }
        public override void MakeSound()
        {
            
            Console.WriteLine("음머~");
        }
    }

    //다음 세 개의 클래스를 만들고 Animal을 상속받으세요.
    //Dog → "멍멍!" 출력
    //Cat → "야옹~" 출력
    //Cow → "음머~" 출력
    //※ 각 동물의 소리는 MakeSound() 메서드 오버라이딩을 통해 구현합니다.


    //Main() 함수에서 각각의 동물을 생성하고, MakeSound() 를 호출하세요.

    static void Main()
    {
        Dog dog = new Dog("댕댕이");
        dog.MakeSound();
        Console.WriteLine();

        Cat cat = new Cat("나비");
        cat.MakeSound();
        Console.WriteLine();

        Cow cow = new Cow("해피카우");
        cow.MakeSound();
        Console.WriteLine();
    }
    //    [출력예시]
    //    안녕하세요, 저는 댕댕이입니다
    //    멍멍!

    //    안녕하세요, 저는 나비입니다
    //    야옹~

    //    안녕하세요, 저는 해피카우입니다
    //    음머 ~
}

