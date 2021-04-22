using System;
//추가 테스트
namespace multiquiz
{
    //// 문제
    // 구구단 랜덤하게 문제를 출제
    // 맞으면 맞습니다.
    // 틀리면 틀렸습니다.

    class Program
    {
        static void Main(string[] args)
        {
            Print("구구단 퀴즈!");

            // 랜덤 -> 첫번째 숫자. 두번째 숫자, -> 랜덤한 숫자 2개가 필요하다.
            int random1 = 0; // 랜덤한 숫자를 할당해야함
            int random2 = 0; // 랜덤한 숫자를 할당해야함
            int rightResult; // 여기에 정답을 넣자.

            // 랜덤한 숫자 할당
            Random rand = new Random();
            random1 = rand.Next(8); // 0 ~ 7;
            random1 = random1 + 2;  // 2 ~ 9;

            random2 = rand.Next();
            random2 = rand.Next(8); // 0 ~ 7;
            random2 = random2 + 2;  // 2 ~ 9:

            // random1 = .

            // 결과 지정
            rightResult = random1 * random2;

            // 문제 출제 // 2 * 3 = ?
            Print($"{random1} * {random2} = ?");                       // <-
            //Print(string.Format("{0} * {1} = ?", random1, random2)); // <-

            // 사용자의 입력을 받자.
            string intputString = Console.ReadLine();
            int userInputNumber = int.Parse(intputString);

            // 맞는지 틀렸는지 확인하자.
            bool isRight = userInputNumber == rightResult;
            if (isRight)
            {
                Print("정답입니다!");
            }
            else
            {
                Print("오답입니다!");
            }
        }

        private static void Print(string log)
        {
            Console.WriteLine(log);

        }
    }
}
