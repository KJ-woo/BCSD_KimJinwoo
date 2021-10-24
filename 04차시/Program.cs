using System;

class Program
{
    class Item
    {
        public string Name;
        int AT;
        int DF;
    }
    static void Main(string[] args)
    {
        //배열은 기본적으로 자료형이라고 할 수 있으며
        //기본자료형에 속한다.
        //선언방식은 어떤 자료형[]

        //모든 자료형은 구조체 아니면 클래스에 가까운데
        //기본자료형도 마찬가지임

        // [0][0][0][0][0][0][0][0][0][0]
        int[] ArrInt = new int[10];
        float[] Arrfloat = new float[10];
        //int Value = ArrInt[0];
        //ArrInt는 int의 배열형(int의 집합)
        //ArrInt[0]은 무슨 자료형인가?

        // C#에서는 모든 자료형은 클래스 혹은
        // 구조체에 가깝다.
        // 맴버 변수와 맴버함수가 있다.

        //배열의 특성 :
        //1.여러개가 모여있는것
        //2. 연속되어있다.
        //모여있는 자료들을 접근하는 방법

        for (int i = 0; i < ArrInt.Length; i++)
        { 
            Console.WriteLine(ArrInt[0]);
        }
        // 배열을 언제 사용하느냐?
        // 아이템이 100개 있다.
        // 클래스도 자료형이다. int 는 기본자료형
        // 클래스는 사용자 정의 자료형!

        //아이템이라는 참조형을
        //담을 수 있는 공간이 10개 생겼다.

        // new Item();
        // 이건 아이템을 만든 것이 아니다.
        //new Item[100]; -> 아이템을 100개 담을 수 있는 녀석을 만든거임

        // Item NewItem; -> 이건 아이템을 가르킬수있는녀석임
        Item NewItem = new Item();// 우변뜻 : 아이템이 생겼다.
        // 좌변 뜻 : NewItem은 하나 생긴 아이템을 가르킨다.
        Item NewItem2 = NewItem; //우변에 있는게 진짜 아이템임

        //레퍼런스란 플레이어가 어딘가 만들었는데 그걸 가르킨다라는거
        // 아이템이라는 메모리를
        // 가리킬수 있는 참조형이 10개 생겼다.
        Item[] ArrItem = new Item[10];//이건 생긴게 아님
        //밑에 적혀져있는 for문이 생긴거임

        for (int i = 0; i < ArrItem.Length; i++)
        {
            ArrItem[i] = new Item();
        }

        ArrItem[0].Name = "철검";
        ArrItem[1].Name = "전설의검";
        ArrItem[2].Name = "갑옷";
        ArrItem[3].Name = "멋진 갑옷";
        ArrItem[4].Name = "포션";

        for (int i = 0; i < ArrItem.Length; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }

        // lllll***
        // ********
        // ********
    } 
 

}