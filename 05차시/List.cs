using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyList<T>
{
    int[] Arr = new int[0];
    int Capa = 0;
    int Count = 0;

    public void Add(T _Add)
    {
        if (Count + 1 >= Capa)
        {
            //확장.
        }
    }
}



namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NewInt = new List<int>();
            NewInt.Add(100);
            // 배열형
            // 시퀸스

            //내가 만든애가 아니고
            // 내가 관리해달라고 요청하는게 매번 바뀌는 거
            //그러므로 제네릭 클래스여야 함.
            // List<Item> NewList = new List<Item>();

            List<int> NewList = new List<int>();

            // 자료:넣어준 int
            for (int i = 0; i < 10; i++){
                Console.WriteLine((i + 1).ToString() + " Add");
                Console.WriteLine("Capacity " + NewList.Capacity); // 배열의크기
                Console.WriteLine("Count " + NewList.Count); // 자료의크기
                NewList.Add(i);
            }

            // 탐색에는 유리하지 않은 자료구조라고 봄
            // if 인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조임
            // 내부에 자료가 있는지 없는지 확인 해볼 것 
            if (NewList.Contains(8)){
                Console.WriteLine("내부에 8이 있다.");
            }
            else{
                Console.WriteLine("내부에 8이 없다.");
            }
            // 인덱서 혹은 연산자 겹지정이라 한다
            Console.WriteLine(NewList[5]);
            NewList.Remove(5); // 5가 있다면 지움
            NewList.RemoveAt(1); // 첫번째를 지움
            //NewList.RemoveAll(); 다른리스트or 배열을 넣어줬을때 비교해서 중복되면 삭제함
            NewList.RemoveRange(0, 4); // 0번째에서 4개를 지워

            for (int i = 0; i < NewList.Count; i++)
            {
                Console.Write(NewList[i]);
            }
        }
    }
}
