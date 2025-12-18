internal class Program
{
    public static void OnEnemyDie(string killerName, int reward)
    {
        Console.WriteLine($"{killerName}이(가) +{reward} 점수를 획득");
        Console.WriteLine($"[효과음] 처치 사운드 재생");
    }
    static void Main( )
    {
        Enemy slime = new Enemy("Slime", 20, 100, OnEnemyDie);
        slime.TakeDamage(5, "Knight"); 
        slime.TakeDamage(20, "Knight");
    }
}

//다음 조건을 만족하는 코드를 작성하세요.

//5. Program 클래스에 콜백 메서드 static void OnEnemyDie(string killerName, int reward)를 구현한다.
// -> 함수 내부에 
// -> "{killerName}이(가) +{reward} 점수를 획득"
// -> "[효과음] 처치 사운드 재생"
// -> 가 출력되도록 구현한다.
//6. Main()에서 다음 순서로 호출 한다.
// -> Enemy slime = new Enemy("Slime", 20, 100, OnEnemyDie);
// -> slime.TakeDamage(5, "Knight"); 
// -> slime.TakeDamage(20, "Knight");

//출력 예시
//[Slime] HP: 15
//[Slime] HP: -5
//[Slime] 처치!
//Knight이(가) + 100 점수를 획득
//[효과음] 처치 사운드 재생
