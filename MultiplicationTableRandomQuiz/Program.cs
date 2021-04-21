using System;

namespace MultiplicationTableRandomQuiz
{
    //// 문제
    // 구구단 랜덤하게 문제를 출제
    // 맞으면 맞습니다.
    // 틀리면 틀렸습니다.

    class Program
    {
        static void Main()
        {
            Print("구구단 퀴즈!");

            // 래덤 -> 첫번째 숫자. 두번째 숫자, -> 랜덤한 숫자 2개가 필요하다
            int r1; //랜덤한 숫자 할당해야함 
            int r2; //랜덤한 숫자 할당해야함
            int rightResult; // 여기에 정답을 넣자.

            // 랜덤한 숫자 할당
            Random rand = new Random();
            //r1 = rand.Next(8) + 2; <-- 아래와 같은 의미
            r1 = rand.Next(8); //0 ~ 7;

            //r1 = r1 + 2;       //2 ~ 9; 
            r1 += 2;


            r2 = rand.Next(8); //0 ~ 7;
            //r2 = r2 + 2;       //2 ~ 9;
            r2 += 2;


            // 결과 지정
            rightResult = r1 * r2;

            // 문제출제 // 2 * 3 = ?
            Print($"{r1} * {r2} = ?");                        //
            //Print(string.Format("{0} * {1} = ?", r1, r2));  // <- 
            
            // 사용자의 입력을 받자.
            string intputString = Console.ReadLine();
            int userInputNumber = int.Parse(intputString);

            // 맞는지 틀렸는지 확인하자.
            bool isRight = userInputNumber == rightResult;
            if (isRight)
            {
                Print("정답입니다");
            }
            else
            {
                Print("오답입니다");
            }
        }

        private static void Print(string log)
        {
            Console.WriteLine(log);
        }
        //깃허브 데스크탑 어렵다

        //private static void Print(string log)
        //{
        //    Console.WriteLine(log);
        //}
    }
}
