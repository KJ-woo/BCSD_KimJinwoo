using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자료구조는 게임 프로그래머의 기본
//자료구조에 대해 알아보자

//자료구조는 데이터 값의 모임, 데이터 간의 관계,
//그리고 데이터에 적용할 수 있는 함수나 명령을 의미한다.

class MyDataStruct <T>
{
    // 넣는다 ()
    // 탐색한다. ()
    // 확장한다. ()
    public void Push(T _Data)
    {
    }
    public void Find(T _Data)
    {
    }
    public void Ex(int _Size)
    {
        //if(이 자료가 들어왔을 때 내 자료가 오버된다면)
        //{
        // MDS.Ex(적절한 수);
        //}
    }
}

namespace _38DataStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료구조라는 건
            // int 10
            // 0 1 2 3 4 5  6 7 8 9  

            // 자료구조에는 다음의 구조나 인터페이스를 지원한다.
            // 함수로 표현


            // 자료를 넣는다.
            // 탐색. ()
            // 확장한다.

            // 최악의 생각
            // 나는 모른다.()
            // 정답을 말해야 한다는 압박감.
            // 모른다고 말하면 안된다.
            

            // 자료구조에는 보통 컨테이너라는 용어를 사용하는데
            // 시퀸스 컨테이너와 - 순차적으로 들어가는게 = 차곡차곡쌓이는게
            // 시퀸스 - List
            // SortedList -> 정렬되는 리스트 = 연관 
            
            // 연관 컨테이너 - 자료간의 연관이 있다 10, 20, 999, 30 이면 -> 10, 20, 30, 999 로 변경되는거
            // 연관 - Dictionary(c# 해쉬 맵)
            // 자료가 들어왔을때 어떠한 규칙에 의해 자료의 순서를 바꾸는거임
            // 어뎁터 컨테이너라는 분류. stack queue

            // 데이터의 메모리 구조는 배열과 노드가 대부분임.

            //자료구조이다.
            int[] Arr = new int[10];

            Arr[0] = 312;
            Arr[1] = 5343;

            int[] Arr2 = Arr;
            Arr = new int[15]; // 이렇게되면 위에 정의했던것들 다 초기화됨

            MyDataStruct<int> MDS = new MyDataStruct<int>();
            // 100을 넣어라
            MDS.Push(100);

            // 50을 찾아라
            MDS.Find(50);

            //넓혀라 but 이러한 과정이 자동으로 이루어지므로 잘 안쓰임
            //MDS.Ex(50000);

        }
    }
}
