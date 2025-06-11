// using System;

// // 문자열 섞기
// public class Q11
// {
//     // 내 풀이
//     public string solution(string str1, string str2) 
//     {
//         string answer = "";
//         int maxLength = str1.Length + str2.Length;

//         for (int i = 0; i < maxLength; i++)
//         {
//             if (i % 2 == 0 && i/2 < str1.Length)
//             {
//                 answer += str1[i/2];
//             }
//             else if (i % 2 == 1 && i/2 < str2.Length)
//             {
//                 answer += str2[i/2];
//             }
//         }
//         return answer;
//     }

//     // 더 나은 풀이
//     public string solution2(string str1, string str2)
//     {
//         string answer = "";

//         for (int i = 0; i < str1.Length; i++)
//         {
//             answer += str1[i].ToString() + str2[i].ToString();
//         }
//         return answer;
//     }
// }