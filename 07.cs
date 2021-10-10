using System;

class Player
{ 
    //가장 처음으로 해야할 일이
    // 내가 rpg 뭘만들고싶다.
    // 클래스를 선언한다.
    //class Dragon
    //{
    //   int AT; // 맴버변수
    //   int HP; // 맴버변수
    //
    //   //맴버함수
    //   void Damage()
    //   {
    //      HP = HP - 10;
    //   }
    //}
    //클래스의 내부
    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자입니다.

    // 이렇게 세가지 접근제한 지정자가 존재한다.
    public int ATT; //외부에도 공개
    protected int HP; // 자식에게만 공개
    private int DEF; //내부에만 공개
    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}//->클래스의 끝

//-> 클래스의 외부
namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름.을 사용한다.
            // 접근제한 지정자라는 문법을 사용하지 않아서
            // 외부에  공개하지 않기로 했다.

            //잘못쓰기도 힘들게 만들어놔라.
            NewPlayer.ATT = 1000;
            NewPlayer.Fight();
        }
    }
}
