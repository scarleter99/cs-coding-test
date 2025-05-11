using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Backjoon1069
{
    static void Main(string[] args)
    {
        var parts = Console.ReadLine().Split();
        long X = long.Parse(parts[0]), 
             Y = long.Parse(parts[1]),
             D = long.Parse(parts[2]), 
             T = long.Parse(parts[3]);

        double dist = Math.Sqrt(X * X + Y * Y);
        double answer;

        // 점프가 걷기보다 느리거나 같으면 무조건 걷기
        if (D <= T)
        {
            answer = dist;
        }
        else
        {
            // 점프를 dist 방향으로 최대로 사용할 횟수
            int n = (int)(dist / D);

            if (dist >= D)
            {
                // 1) 전부 걷기
                double time1 = dist;
                // 2) n번 점프 + 나머지 걷기
                double time2 = n * T + (dist - n * D);
                // 3) (n+1)번 점프만으로
                double time3 = (n + 1) * T;
                answer = Math.Min(time1, Math.Min(time2, time3));
            }
            else
            {
                // dist < D 인 경우
                // 1) 전부 걷기
                double time1 = dist;
                // 2) 한 번 점프하고 되돌아 걷기
                double time2 = T + (D - dist);
                // 3) 점프 두 번
                double time3 = 2 * T;
                answer = Math.Min(time1, Math.Min(time2, time3));
            }
        }

        // Special Judge(허용 오차)이므로 충분히 많은 소수 자리까지 출력
        Console.WriteLine(answer.ToString("F10"));
    }
}