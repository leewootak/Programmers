using System;

// 더 크게 합치기
public class Q14
{
    // 내 풀이
    public int solution(int a, int b)
    {
        int answer = 0;
        string s1 = a.ToString() + b.ToString();
        string s2 = b.ToString() + a.ToString();

        int i1 = int.Parse(s1);
        int i2 = int.Parse(s2);

        answer = Math.Max(i1, i2);
        return answer;
    }

    // 더 나은 풀이
    public int solution2(int a, int b)
    {
        int answer = 0;
        int i1 = int.Parse($"{a}{b}");
        int i2 = int.Parse($"{b}{a}");
        answer = Math.Max(i1, i2);
        return answer;
    }
}