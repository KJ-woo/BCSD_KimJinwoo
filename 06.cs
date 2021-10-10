using System;

class Player
{
    // 맴버변수 -> 클래스 내부에 있다고 해서 맴버변수
    int Att;
    int Hp;
    void Fight()
    {
        // 선언되는 순간 지역변수는 메모리화 되고
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다.");
    }
}//게임에서 사용하기 위해서 여기까지 설계했다.

namespace _06LocalVar
{
    // c#은  고지식한 객체지향 언어
    // 클래스밖에 모르는 바보~
    // 프로그램의 시작조차도 클래스안에 묶어놔야 한다.
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스 안에 있으면 맴버변수

            // 함수안에 있는 녀석들을 지역변수라고 한다.
            // 지역변수 규칙
            //{
            // 내부에서 만 사용가능하다.
            //}
            int ATT = 0;
            ATT = 50;
            // 객체화라는 굉장히 중요한 작업
            // 설계도.
            //Player의 설계대로 플레이어를 만드는데
            // 그 이름을 NewPlayer라고 한거
            //Player NewPlayer = new Player();
        }
    }
}
