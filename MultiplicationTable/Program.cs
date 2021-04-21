using System;

namespace multiplication_table
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("출력할 구구단을 입력하세요 - 111");
            Console.WriteLine("222222222");

            string readString = Console.ReadLine();

            int number = int.Parse(readString);

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{number} X {i + 1} = {number * (i + 1)}");
            }
        }
    }
}

