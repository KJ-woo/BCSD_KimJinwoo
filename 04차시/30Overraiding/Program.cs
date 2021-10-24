using System;
//부모의 이름이 같은 자식함수라면 서로 타입이 동일해야함Protected라면
//Protected, Private라면 Private 
//
class FightUnit
{


    //외부 자식 내부 까지만
    //디폴트 접근제한지정자는 private
    protected string Name = "NONE";
    protected int AT = 10;
    //protected int ItemAT = 10; 이변수를 쓰는순간 몬스터는 가질필요가없기때문에
    //객체지향을 부정하는것임.
    protected int HP = 100;
    
    //이문법의 핵심은
    // 자식에서 만약 나의 같은 이름의 함수나 프로퍼티를 재구현했다고한다면
    // 자식의 형태의 같은 이름의 함수나 프로퍼티를 호출해 주세요.
    // 이걸 오버라이딩
    // 다형성(동적바인딩)의 핵심 문법중 하나이다.
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHT의 GETAT");
        return AT;
    }

    //번외 get set 반환자 설정자 하기싫어서 만든 문법
    //프로퍼티
    public virtual int DMGAT
    {
        get
        {
            Console.WriteLine("FIGHTUNIT의 GETAT");
            return AT;
        }
    }
    //업캐스팅
    //DamageFightUnit
    //첫번째 상속의 개념을 지키기 위해서
    // 코드 재활용성 -> 코드를 적게치고 최대한의 효과를 얻기위함
    public void Damage(FightUnit _OtherFightUnit)
    {
        //각자 플레이어면 플레이어의 것
        // _OterFightUnit.AT
        int AT = _OtherFightUnit.DMGAT;
        Console.WriteLine(_OtherFightUnit.Name + "에게"+ _OtherFightUnit.GetAT() + "만큼의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }

    //생성자는 오버라이딩 할 수 없다.
    /*public virtual FightUnit()
    {

    }*/



    //오버로딩 이렇게 설정해버리면 다른 클래스를 가지는 함수를
    //여러개를 정의해야하므로 좋지않음
    //DamagePlayer
    /*public void Damage(Player _OtherFightUnit)
    {
        Console.WriteLine(_OtherFightUnit.Name + "에게" + _OtherFightUnit.AT + "만큼의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }*/
}
class Player : FightUnit
{
    int ItemAt = 5;

    //나는 부모님의 GetAT를 재구현 했다.
    public override int DMGAT
    {
        get
        {
            Console.WriteLine("플레이어의 DMGAT");
            return AT + ItemAt;
        }
    }
    public Player(String _Name)
    {
        Name = _Name;
    }
}
class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GETAT");
        return AT + MonsterLv;
    }

    public Monster(String _Name)
    {
        Name = _Name;
    }
}

namespace _30Overraiding
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Player NewPlayer = new Player("JW");
            Monster NewMonster = new Monster("괴물");

            //NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);//->getat 호출하면 fight getat가 호출됨
            NewMonster.Damage(NewPlayer);
        }
    }
}
