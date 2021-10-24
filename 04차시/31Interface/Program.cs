using System;


//interface = 사용자 정의 자료형이다.
interface QuestUnit
{
    //맴버변수를 인터페이스 내에 넣을 수 없음
    //int A = 0;
    // private를 정의할 수도 없음 무조건 public
   
    //인터페이스 내에서는 함수에 구체적인 코드 자체를 못적음.

    // 함수의 형태만 물려줄 수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);

    void Event(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;
    public void Damage()
    {
    }
}


// 인터페이스는 함수구현을 강제할 수 있다.
// 인터페이스는 상속이라고 안하는 사람도 있음
// 포함의 개념이다라고 말하는 사람도 있음.
// 인터페이스를 상속받았다고 치면
// 나는 talk를 다 구현해줘야함 
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}
class NPC : FightUnit, QuestUnit
{// 이렇게 QuestUnit 인터페이스를 상속받게 되면 QuestUnit안에 있는
 // 모든 함수를 구현해야함. 또한 public으로 구현해야함 
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}



  class Program
  {
      static void Main(string[] args)
      {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();


        //업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
      }
  }
