// using System;

// // 수 조작하기 2
// public class Q28
// {
//     public string solution(int[] numLog)
//     {
//         string answer = "";

//         for (int i = 0; i < numLog.Length - 1; i++)
//         {
//             int num = numLog[i + 1] - numLog[i];
//             switch (num)
//             {
//                 case 1:
//                     answer += 'w';
//                     break;
//                 case -1:
//                     answer += 's';
//                     break;
//                 case 10:
//                     answer += 'd';
//                     break;
//                 case -10:
//                     answer += 'a';
//                     break;
//             }
//         }
//         return answer;
//     }
// }