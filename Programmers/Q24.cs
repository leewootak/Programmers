// using System;

// // 원소들의 곱과 합
// public class Q24
// {
//     // 내 풀이
//     public int solution(int[] num_list)
//     {
//         int answer = 0;
//         int sum1 = 1;
//         int sum2 = 0;

//         for (int i = 0; i < num_list.Length; i++)
//         {
//             sum1 *= num_list[i];
//             sum2 += num_list[i];
//         }

//         if (sum1 < sum2 * sum2)
//             return 1;
//         else if (sum1 > sum2 * sum2)
//             return 0;

//         return answer;
//     }

//     // 더 나은 풀이
//     public int solution2(int[] num_list)
//     {
//         int sum1 = 1;
//         int sum2 = 0;

//         for (int i = 0; i < num_list.Length; i++)
//         {
//             sum1 *= num_list[i];
//             sum2 += num_list[i];
//         }
//         // Math.Pow(Array.Sum(), n) 배열의 모든 요소의 합을 n제곱
//         return sum1 > Math.Pow(num_list.Sum(), 2) ? 0 : 1;
//     }
// }