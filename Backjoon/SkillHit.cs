using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class SkillHit
{
    static void Main(string[] args)
    {
        double x1 = 1;
        double y1 = 2;
        double x2 = 4;
        double y2 = 5;
        double x3 = 3;
        double y3 = 3;
        double r = 3;
        double ceta = 30;

        double dx = x3 - x1;
        double dy = y3 - y1;
        double d = Math.Sqrt(dx * dx + dy * dy);

        string answer = "";
        if (d > r){
            answer = "Miss";
        }
        else{
            double dx2 = x2 - x1;
            double dy2 = y2 - y1;
            double d2 = Math.Sqrt(dx2 * dx2 + dy2 * dy2);
            
            double dot = dx * dx2 + dy * dy2;
            double angle = Math.Acos(dot / (d * d2));

            if (angle <= ceta * Math.PI / 180){
                answer = "Hit";
            }
            else{
                answer = "Miss2";
            }
        }

        Console.WriteLine(answer); // Hit
    }
}