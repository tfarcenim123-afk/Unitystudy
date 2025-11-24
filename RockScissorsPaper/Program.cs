namespace RockScissorsPaper
{   //가위바위보 게임 만들기
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("가위 바위 보 게임 (1:가위, 2:바위, 3:보)");
            Console.WriteLine("==============================================");

            // 플레이어 선택
            Console.Write("선택하세요: ");
            string playerInput = Console.ReadLine();
            if (playerInput != "1" && playerInput != "2" && playerInput != "3")
            {
                Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
            }
            else
            {
                int playerChoice = int.Parse(playerInput);

                // 컴퓨터 선택
                Random rand = new Random();
                int comChoice = rand.Next(1, 4); // 1 ~ 3 의 랜덤 값을 넣어짐

                // 컴퓨터 선택 출력
                switch (comChoice)
                {
                    case 1:
                        Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                        break;
                    case 2:
                        Console.WriteLine("컴퓨터는 바위를 냈습니다.");
                        break;
                    case 3:
                        Console.WriteLine("컴퓨터는 보를 냈습니다.");
                        break;
                    default:
                        break;
                }

                // 결과 출력

                int result = playerChoice - comChoice;
                switch (result)
                {
                    //플레이어가 이긴 경우
                    case 1:
                    case -2:
                        Console.WriteLine("당신이 이겼습니다!");
                        break;

                    //컴퓨터가 이긴 경우
                    case -1:
                    case 2:
                        Console.WriteLine("컴퓨터가 이겼습니다!");
                        break;

                    //비긴 경우
                    case 0:
                        Console.WriteLine("비겼습니다!");
                        break;

                    default:
                        break;
                }
            }
            // 아래에 추가로 코드를 작성하여 프로그램을 완성해 주세요.
            // 결과 화면 예시
            /*
                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 1
                컴퓨터는 보를 냈습니다.
                당신이 이겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 2
                컴퓨터는 보를 냈습니다.
                컴퓨터가 이겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 3
                컴퓨터는 보를 냈습니다.
                비겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 5
                컴퓨터는 보를 냈습니다.
                잘못된 입력입니다. 1~3 중 하나만 입력해주세요.
             */
        }
    }
}
