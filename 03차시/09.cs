using System;

class Player
{
    int HP = 100; //리터럴

    void Damage(int _HP)
    {
        HP = HP - 10;
    }
    public int Plus(int _Left, int _Right)
    {
        int Result = _Left + _Right;
        return Result;

    }
}

namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            int Result = 0;
            int Left = 3;
            int Right = 7;

            //= 대입연산자.
            // 함수에서 리턴된 값이나
            // 혹은 연산이된 값을 리터럴 값일때도 있음
            // 그값을 받을 수 있는 변수에 넣어줘라

            //산술연산자.
            // 리턴값이라는것은
            //외부에 연산값이나 객체 상태값등을 끝나고나면 외부에
            // 반환하는 것을 말하고 이런식으로 =연산자가있다면 오른쪽부터 시작
            // 이것을 연산자 우선순위라고 함.
            // 산술연산자에는 */% 가 먼저 되고
            // + - 가 된다.
            Result = NewPlayer.Plus(Left, Right); //더하기
            Result = Left + Right;//더하기
            Result = Left - Right;//빼기
            Result = Left * Right;//곱하기
            Result = Left / Right;//나누기
            Result = Left % Right;//나머지
            //()연산자는 우선순위 지정
            Result = (Left + Right) * 10;
            //이런식으로 산술 연산을 할 수 있고,
            // 한가지 주의할점은
            // 나누기와 나머지는 0을 넣으면 안된다.
            // 10 / 0 은 수학에서는 불가능하다.
            // 컴퓨터에는 제로디비전이라고해서 아예 오류가 발생
            //프로그램이 실행도중 터질정도의 오류이기에 조심해야함


            // 비교연산자는논리형으로 리턴
            //논리형은 bool이라는 녀석
            // 참과 거짓이 상수화 된것을 true, false로 정함
            bool BResult = true;
            BResult = false;

            //참이라면 true를 반환 거짓이라면 false를 반환
            // 나중에 배울 조건문에서 정말 유용하게 이용된다.
            BResult = Left > Right; //Left가 Right보다 큰가?
            BResult = Left < Right;//Left가 Right보다 작은가?
            BResult = Left <= Right;//Left가 Right보다 작거나 같은가?
            BResult = Left >= Right;//Left가 Right보다 크거나 같은가?
            BResult = Left == Right;//Left가 Right보다 같은가?
            BResult = Left != Right;//Left가 Right보다 다른가?

            // bool 논리 연산자
            // 참과 거짓을 연산하는 연산자
            BResult = !true; // true면 false

            BResult = true && false;//and 둘다 true일때만 true가 됨
            BResult = true && true; //true나옴
            //연속되어 있을 때 그 중 단 1개라도 false면 false다.
            BResult = true && false && true;

            //이녀석은 하나라도 true가 있다면 true가 나옴
            BResult = true || false;// or

            // 다르다면 true
            // 같다면 false가 되는 연산이다.
            BResult = true ^ false;// xor
            BResult = false ^ true;
            BResult = true ^ true;
            BResult = false ^ false;

            //축약 연산자
            Result = 0;
            Result = Result + 10;
            Result += 10;

            Result /= 10;
            Result *= 10;

        }
    }
}
