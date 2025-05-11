using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class Backjoon11758
{
    static void Main(string[] args)
    {
        // 세 점의 좌표 입력
        int[] p1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] p2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] p3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // 벡터 계산
        int x1 = p2[0] - p1[0];
        int y1 = p2[1] - p1[1];
        int x2 = p3[0] - p2[0];
        int y2 = p3[1] - p2[1];

        // 외적 계산
        int cross = x1 * y2 - y1 * x2;

        // 방향 판단
        if (cross > 0)
            Console.WriteLine(1);    // 반시계 방향
        else if (cross < 0)
            Console.WriteLine(-1);   // 시계 방향
        else
            Console.WriteLine(0);    // 일직선
    }
}