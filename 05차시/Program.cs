using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DicTest
{

    public Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Add(string _Name, int Value)
    {
        if (true == NewDic.ContainsKey(_Name)){
            return;
        }
        NewDic.Add(_Name, Value);

    }

    public void Print(string _Name)
    {

        if (false == NewDic.ContainsKey(_Name))
        {
            return;
        }
        Console.WriteLine(NewDic[_Name]);
    }
}
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DicTest NewTest = new DicTest();
            Dictionary<string, int> NewDic = new Dictionary<string, int>();
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하1", 21);
            NewTest.Add("키입니다", 1);
            Console.WriteLine(NewTest.NewDic["하하하1"]);
            NewTest.Print("키입니다");
            // 연관 복합
            // String 키
            // int Value (데이터)
            //
            //Dictionary<String, int> NewDic = new Dictionary<string, int>();


            NewDic.Add("일이에요", 1);
            NewDic.Add("이에요", 2);
            NewDic.Add("뭘까요?", 877978);
            NewDic.Add("와와재밌다", 2342); //똑같은 키를 두번 못넣는다.
            NewDic.Remove("와와재밌다");
            string key = "없는값 테스트";

            //인덱서
            //연산자 겹지정이라고 함
            //딕셔너리는 찾는다는 작업에 특화되어있음

        }
    }
}
