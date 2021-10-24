using System;
enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}
class Player
{
    // 물리방어
    int AttDef = 5;
    // 불방어
    int FireDef = 5;
    // 물방어
    int IceDef = 5;

    int Hp = 100;
    //함수 오버로딩 (함수이름은 동일하되 매개변수가 다르면
    //다른함수로 인식한다)

    public Player()
    {

    }
    public Player(int _Hp)
    {
        Hp = _Hp;
    }
    static void Func(int _Value)
    {

    }

    static void Func(int _Value, int _Value2)
    {

    }






    //Damageint
    public void Damage(int _Damage)
    {
        Hp -= _Damage;

    }

    //Damagefloat
    public void Damage(float _Damage)
    {

    }
    // Damageintint
    public void Damage(int _Damage,DMGTYPE _Type)
    {
        switch(_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }

    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player New2Player = new Player(1000);//생성자 오버로딩
            NewPlayer.Damage(100);
            NewPlayer.Damage(100,DMGTYPE.FIREDMG);
        }
    }
}
