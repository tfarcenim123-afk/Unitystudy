class Program
{
    class Character
    {
        public Character()
        {
            
        }

        public string name = string.Empty;
        public int hp;
        public int atk;

        //this가 공격하면 target의 체력을 this의 공격력만큼 감소시킴
        public void Attack(Character target)
        {
            Console.WriteLine($"{this.name}의 공격! {target.name}에게 {this.atk}만큼 피해를 주었다.");
            Console.WriteLine();

            target.hp = Math.Max(target.hp - this.atk, 0);
        }

        //캐릭터의 hp가 0이면 사망 판정
        public bool IsDead()
        {
            return this.hp == 0;
        }
    }

    class Player : Character
    {
        //플레이어 생성자
        public Player(string name) : base()
        {
            this.name = name;
            hp = 100;
            atk = 10;
        }

        //경험치
        public int playerExp = 0;
        public int expAmount = 10;

        //경험치 획득할 때
        public void GainExp()
        {
            playerExp += expAmount;

            Console.WriteLine($"{expAmount} 경험치를 얻었습니다.");
            Console.WriteLine();
        }
    }

    class Monster : Character
    {
        //몬스터 이름 랜덤으로 정해주기
        static string RandomName()
        {
            string[] names = { "슬라임", "고블린", "늑대", "박쥐" };
            return names[new Random().Next(names.Length)];
        }

        //몬스터 체력과 공격력 랜덤으로 정해주기
        Random monsterHp = new Random();
        Random monsterAtk = new Random();

        //몬스터 생성자
        public Monster() : base()
        {
            name = RandomName();
            hp = monsterHp.Next(20, 51);
            atk = monsterAtk.Next(2, 7);
        }
    }

    static void Main()
    {
        //게임 초기화
        bool isGameOver = false;

        Console.Clear();
        Console.Title = "Console Dungeon";

        //플레이어 이름 입력 받기
        Console.Write("이름을 입력하세요: ");
        
        //플레이어 생성
        Player player = new Player(Console.ReadLine());

        //몬스터
        Monster monster = null;

        //게임 루프
        while (!isGameOver)
        {
            //몬스터 스폰
            if (monster == null || monster.IsDead())
            {
                monster = new Monster();
            }

            //플레이어 상태 창
            Console.WriteLine("================================================");
            Console.WriteLine($"| {player.name, -4} | HP: {player.hp, 4} | ATK: {player.atk, 4} | EXP: {player.playerExp, 4} |");

            //몬스터 상태 창
            Console.WriteLine("================================================");
            Console.WriteLine($"| {monster.name, -4} | HP: {monster.hp, 4} | ATK: {monster.atk, 4} |");

            //플레이어가 게임을 계속하고 싶은지 확인
            Console.WriteLine("================================================");
            Console.Write("계속 싸우시겠습니까? | Y : 예 | N : 아니오 |  ");

            //플레이어가 유효한 키를 입력했는지
            bool isValidKey = false;

            while (!isValidKey)
            {
                //플레이어 키 입력 감지
                ConsoleKeyInfo playerInput = Console.ReadKey();

                switch (playerInput.Key)
                {
                    //Y 입력시
                    case ConsoleKey.Y:
                        isValidKey = true;
                        isGameOver = false;
                        break;

                    //N 입력시
                    case ConsoleKey.N:
                        isValidKey = true;
                        isGameOver = true;
                        break;

                    //유효하지 않은 키 입력 시
                    default:
                        break;
                }
            }

            //줄 띄우기
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine();

            //플레이어가 몬스터를 공격
            player.Attack(monster);

            //몬스터 사망 판정, 사망했다면 플레이어는 경험치 획득
            if (monster.IsDead())
            {
                player.GainExp();
            }
            else
            {
                //몬스터가 사망하지 않았다면 플레이어를 공격
                monster.Attack(player);
            }

            //플레이어 사망 판정, 사망했다면 게임 종료
            if (player.IsDead())
            {
                isGameOver = true;
                break;
            }
        }

        //게임 종료
        Console.Clear();
        Console.WriteLine("GAME OVER");
    }
}