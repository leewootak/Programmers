// using System;

// // 이어 붙인 수
// public class Q25
// {
//     public int solution(int[] num_list)
//     {
//         int answer = 0;
//         string even = "";
//         string odd = "";

//         for (int i = 0; i < num_list.Length; i++)
//         {
//             if (num_list[i] % 2 == 0)
//                 even += $"{num_list[i]}";
//             else
//                 odd += $"{num_list[i]}";
//         }
//         answer = int.Parse(even) + int.Parse(odd);
//         return answer;
//     }
// }