using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class Backjoon7869
{
    static void Main(string[] args)
    {
        // 입력 파싱
        string[] parts = Console.ReadLine().Split();
        double x1 = double.Parse(parts[0]);
        double y1 = double.Parse(parts[1]);
        double r1 = double.Parse(parts[2]);
        double x2 = double.Parse(parts[3]);
        double y2 = double.Parse(parts[4]);
        double r2 = double.Parse(parts[5]);

        // 두 중심 간 거리
        double dx = x1 - x2;
        double dy = y1 - y2;
        double d = Math.Sqrt(dx * dx + dy * dy);

        double area;
        // 겹치지 않는 경우
        if (d >= r1 + r2)
        {
            area = 0;
        }
        // 한 원이 다른 원에 완전히 포함된 경우
        else if (d <= Math.Abs(r1 - r2))
        {
            double rmin = Math.Min(r1, r2);
            area = Math.PI * rmin * rmin;
        }
        // 일반적인 교차 영역 계산
        else
        {
            // 각 원에서의 교차부 부채꼴 각도 (radian)
            double alpha = 2 * Math.Acos((r1 * r1 + d * d - r2 * r2) / (2 * r1 * d));
            double beta  = 2 * Math.Acos((r2 * r2 + d * d - r1 * r1) / (2 * r2 * d));
            Console.WriteLine(alpha);
            Console.WriteLine(beta);
            // 부채꼴 넓이에서 삼각형 넓이(중심-교점-교점)를 뺀 값
            double area1 = 0.5 * r1 * r1 * (alpha - Math.Sin(alpha));
            double area2 = 0.5 * r2 * r2 * (beta  - Math.Sin(beta));
            area = area1 + area2;
        }

        // 셋째 자리 반올림, 고정 소수점 3자리 출력
        Console.WriteLine(
            Math.Round(area, 3).ToString("F3")
        );
    }
}