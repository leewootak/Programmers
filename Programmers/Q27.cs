// using System;
// // 수 조작하기
// public class Solution {
//     public int solution(int n, string control) {
//         int answer = 0;
//         for (int i = 0; i < control.Length; i++)
//         {
//             if (control[i] == 'w')
//                 n++;
//             else if (control[i] == 's')
//                 n--;
//             else if (control[i] == 'd')
//                 n += 10;
//             else if (control[i] == 'a')
//                 n -= 10;
//         }
//         answer += n;
//         return answer;
//     }
// }