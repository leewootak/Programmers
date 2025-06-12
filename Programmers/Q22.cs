// using System;

// // 등차수열의 특정한 항만 더하기
// public class Q22
// {
//     public int solution(int a, int d, bool[] included)
//     {
//         int answer = 0;
//         for (int i = 0; i < included.Length; i++)
//         {
//             if (included[i] == true)
//             {
//                 answer += a;
//             }
//             a += d;
//         }
//         return answer;
//     }
// }