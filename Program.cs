using System;

namespace MultiplicationTableRandomQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("구구단 퀴즈!");

            int random1 = 0;
            int random2 = 0;

            int rightResult;

            Random rand = new Random();
            random1 = rand.Next(8) + 2;
            random1 = random1 + 2;

            random2 = rand.Next();
            random2 = rand.Next(8);
            random2 = random2 + 2;


            //random1 =
            //random2 = 

            rightResult = random1 * random2;

            //Console.WriteLine($"{random1} * {random2} = ?");
            Print($"{random1} * {random2} = ?");
            Print(string.Format("{0} * {1} = ?", random1, random2));


            string intputString = Console.ReadLine();
            int userInputNumber = int.Parse(intputString);

            bool isRight = userInputNumber == rightResult;
            if (isRight)
            {
                Print("정답입니다.");
            }
            else
            {
                Print("오답입니다.");
            }

        }

        private static void Print(string log)
        {
            Console.WriteLine(log);
        }
    }
}
