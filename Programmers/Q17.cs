// using System;

// // 공배수
// public class Q17
// {
//     public int solution(int number, int n, int m)
//     {
//         int answer = 0;
//         if (number % n == 0)
//         {
//             if (number % m == 0)
//                 return 1;
//             else
//                 return 0;
//         }
//         return answer;
//     }

//     // 더 나은 풀이 1
//     public int solution2(int number, int n, int m)
//     {
//         if (number % n != 0) return 0;
//         if (number % m != 0) return 0;
//         return 1;
//     }
// }