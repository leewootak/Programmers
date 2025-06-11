// using System;

// 홀짝에 따라 다른 값 반환하기
// public class Q18
// {
//     // 내 풀이
//     public int solution(int n)
//     {
//         int answer = 0;
//         if (n % 2 == 0)
//         {
//             for (int i = 0; i <= n; i++)
//             {
//                 if (i % 2 == 0)
//                     answer += i * i;
//             }
//         }
//         else
//         {
//             for (int i = 0; i <= n; i++)
//             {
//                 if (i % 2 != 0)
//                     answer += i;
//             }
//         }
//         return answer;
//     }

//     // 더 나은 풀이
//     public int solution2(int n)
//     {
//         int answer = 0;
//         while (n >= 0)
//         {
//             answer += n % 2 == 0 ? n * n : n;
//             n -= 2;
//         }
//         return answer;
//     }
// }