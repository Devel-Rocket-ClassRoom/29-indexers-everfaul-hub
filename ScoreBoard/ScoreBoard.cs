using System;

class Program
{
    static void Main()
    {
        ScoreBoard sb = new ScoreBoard(5);

        sb.Register("김민수", 85);
        sb.Register("이지영", 92);
        sb.Register("박서준", 78);

        Console.WriteLine($"등록된 학생 수: {sb.Count}명\n");

        for (int i = 0; i < sb.Count; i++)
        {
            Console.WriteLine($"{i}번: {sb[i]}");
        }
        Console.WriteLine();

        Console.WriteLine($"김민수 점수: {sb["김민수"]}점");
        Console.WriteLine($"이지영 점수: {sb["이지영"]}점");
        Console.WriteLine($"홍길동 점수: {sb["홍길동"]}점\n");

        sb["김민수"] = 95;
        Console.WriteLine($"김민수 수정된 점수: {sb["김민수"]}점");
    }
}