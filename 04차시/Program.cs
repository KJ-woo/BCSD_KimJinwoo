using System;
using System.Collections.Generic;
using System.Text;
// using _28Partial -> _28Partial 을 생략하고 하겠다
// Player NewPlayer = new Player();로 가능
class Program
{
    static void Main(string[] args)
    {
        /*_28Partial.*/Player NewPlayer = new /*_28Partial.*/Player();
        NewPlayer.Damage();
        NewPlayer.EventStart();
        //이것과 같이 player.Quest, Fight클래스로 쪼갰으나 Program에서도 사용가능하는거
    
    }

}
