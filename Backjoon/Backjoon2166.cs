using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class Backjoon2166
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] x = new long[n + 1];
        long[] y = new long[n + 1];

        for (int i = 0; i < n; i++)
        {
            var parts = Console.ReadLine().Split();
            x[i] = long.Parse(parts[0]);
            y[i] = long.Parse(parts[1]);
        }

        // 순환을 위해 첫 좌표를 마지막에 한 번 더 저장
        x[n] = x[0];
        y[n] = y[0];

        // 신발끈 공식
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += x[i] * y[i + 1] - x[i + 1] * y[i]; 
        }

        double area = Math.Abs(sum) / 2.0;
        // 소수점 아래 둘째 자리에서 반올림하여 첫째 자리까지 출력
        string output = Math.Round(area, 1).ToString("F1");
        Console.WriteLine(output);
    }
}