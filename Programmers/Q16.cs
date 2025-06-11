// using System;

// // n의 배수
// public class Q16
// {
//     // 내 풀이
//     public int solution(int num, int n)
//     {
//         int answer = 0;
//         if (num % n == 0)
//             answer = 1;
//         else
//             answer = 0;
//         return answer;
//     }

//     // 더 나은 풀이
//     public int solution2(int num, int n)
//     {
//         int answer = num % n == 0 ? 1 : 0;
//         return answer;
//     }
// }