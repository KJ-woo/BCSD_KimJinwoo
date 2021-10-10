using System;

class Player
{
    // 접근제한 지정자를 입력하지 않으면
    // 디폴트는 private로 지정된다.
    // 속성들은
    // 외부에서 접근하지 못하는게 일반적으로 좋다.
    int LV = 1;
    int AT = 10;
    int HP = 100;

    // 플레이어의 레벨이 얼마인지 알고 싶다.
    // 인자 값이 아니고
    // 리턴값을 사용해 보겠다
    // 리턴값이란 객체가 자신의 상태를 외부에 알려주는
    // 용도로 사용한다.
    // 외부에 알려줘야 하기 때문에 알려주는 순간
    // 함수가 끝나게 된다.
    // 이 return이라는 문장을 사용하면
    //얼마나 많은 코드가 return 아래에 있든 함수가 종료하게 된다.
    public int GetLv()
    {
        // 리턴을 하는 순간 함수가 끝나고
        // 아래에 친 코드들은 모두 의미가 없다.
        return LV;
    }
    // 상태라는건 맴버변수
    // 어떤 상태가 변화하는 순간.
    // 각각 증가시키거나

    public void SetHp(int _HP)
    {
        HP = _HP;
    }

    // 함수는 보통 선언과
    // 내용으로 나뉘게 되는데
    // void(리턴값) Func(이름 혹은 식별자)()[인자값]
    public void Func()
    {

    }
    //함수란 보통 클래스 외부와의 소통을 위해서 만든거다
    //damage는 맞는다라는 뜻
    // (int _Dmg)를 넣는다는 것은 외부에서
    //한개의 int 값을 넣어서
    //플레이어에게 전달해 주겠다.
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }
    // 리턴값은 자신이 리턴해주려는 자료형과
    // 동일한 자료형 이어야 한다.
    public int DamageToHPReturn(int _Dmg, int _Dmg1)
    {
        HP = HP - _Dmg;
        return HP;
    }
    //두개가 될수도 있다.
    // 개수는 신경안써도 될정도로
    //100개 이상은 넣어주실수 있다.
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
    public void LVUP()
    {
        AT += 100;
        HP += 1000;
    }
}
// 플레이어가 어떤 사양과 내용을 가졌다.
// 만든건 아니다.

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // 그래서 필요한 것이 함수이다.

            // 함수로 안하면 불편한점은 일일이 다 쳐줘야한다는 점
            // 번거러움
            NewPlayer.LVUP();
            NewPlayer.SetHp(1000);

            //이런식으로 외부의 값을 받아서
            // 객체가 내부의 상태를 변화시키기 위해서
            // 함수를 선언하는 경우가 많다.
            NewPlayer.Damage1(10);
            NewPlayer.Damage2(10, 20);

            Console.WriteLine(NewPlayer.GetLv());
            Console.WriteLine(NewPlayer.DamageToHPReturn(10,20));

            //함수로 설정하는거의 장점은 디버깅할때 좋음
            // 내가 HP가 0이되는 순간, 1000이되는순간 다 체크가 가능
        }
    }
}
