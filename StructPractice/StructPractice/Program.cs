using System.Security.Cryptography.X509Certificates;

class Program
{
    enum ClassType
    {
        None,
        Knight,
        Mage,
        Rogue
    }

    enum MonsterType
    {
        None,
        Slime,
        Orc,
        Skeleton
    }

    struct Player
    {
        public int hp;
        public int atk;
    }

    struct Monster
    {
        public int hp;
        public int atk;
    }

    static ClassType ClassChoice()
    {
        Console.WriteLine("직업을 선택하세요!");
        Console.WriteLine("[1] 기사");
        Console.WriteLine("[2] 마법사");
        Console.WriteLine("[3] 도둑");

        ClassType choice = ClassType.None;
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                choice = ClassType.Knight;
                break;
            case "2":
                choice = ClassType.Mage;
                break;
            case "3":
                choice = ClassType.Rogue;
                break;
        }

        return choice;
    }

    static void CreatePlayer(ClassType choice, out Player player)
    {
        // 기사(100/10), 마법사(50/15), 도둑(75/12)
        switch (choice)
        {
            case ClassType.Knight:
                player.hp = 100;
                player.atk = 10;
                break;

            case ClassType.Mage:
                player.hp = 50;
                player.atk = 15;
                break;

            case ClassType.Rogue:
                player.hp = 75;
                player.atk = 12;
                break;
            default:
                player.hp = 0;
                player.atk = 0;
                break;
        }
    }

    static void CreateRandomMonster(out MonsterType monsterType, out Monster monster)
    {
        Random random = new Random();

        switch (random.Next(1, 4))
        {
                case 1:
                monsterType = MonsterType.Slime;
                monster.hp = 20;
                monster.atk = 2;
                break;

                case 2:
                monsterType = MonsterType.Orc;
                monster.hp = 40;
                monster.atk = 4;
                break;

                case 3:
                monsterType = MonsterType.Skeleton;
                monster.hp = 30;
                monster.atk = 3;
                break;

                default:
                monsterType = MonsterType.None;
                monster.hp = 0;
                monster.atk = 0;
                break;
        }
    }
    static void Main()
    {
        Player player;

        Monster monster;

        ClassType choice = ClassType.None;

        MonsterType monsterType = MonsterType.None;

        while (true)
        {

            choice = ClassChoice();

            if (choice != ClassType.None)
            {
                // 캐릭터 생성
                CreatePlayer(choice, out player);

                Console.WriteLine($"HP {player.hp}, ATK {player.atk}");

                CreateRandomMonster(out monsterType, out monster);

                Console.WriteLine($"{monsterType}이 나타났다! HP {monster.hp}, ATK {monster.atk}");
            }
        }
    }
}
