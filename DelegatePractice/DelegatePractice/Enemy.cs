internal class Enemy : Program
{
    public delegate void OnDie(string killerName, int reward);

    private string Name;
    private int Hp;
    public int Reward;
    private OnDie DieCallback;

    public Enemy(string name, int hp, int reward, OnDie? dieCallback)
    {
        Name = name;
        Hp = hp;
        Reward = reward;
        DieCallback = dieCallback;
    }

    public void TakeDamage(int amount, string attacker)
    {
        Hp -= amount;
        Console.WriteLine($"[{Name}] HP: {Hp}");

        if (Hp <= 0)
        {
            Console.WriteLine($"[{Name}] 처치!");

            if (DieCallback != null)
            {
                DieCallback.Invoke(attacker, Reward);
            }
        }

    }
}

//1.Enemy 클래스 내부에 델리게이트 OnDie를 정의한다.
// -> 시그니처: void(string killerName, int reward)
//2.Enemy 클래스는 다음 멤버를 가진다.
// -> string Name, int Hp, int Reward, OnDie dieCallback(private)
//3.생성자 Enemy(string name, int hp, int reward, OnDie onDieCallback)에서 모든 필드를 초기화한다.
//4. void TakeDamage(int amount, string attacker) 함수를 정의한다.
// -> Hp에서 amount만큼 감소시키고 "[{Name}] HP: {Hp}"를 출력한다.
// -> Hp가 0 이하가 되면 "[{Name}] 처치!"를 출력하고,
// -> dieCallback이 null이 아니면 dieCallback(attacker, Reward)를 호출한다.