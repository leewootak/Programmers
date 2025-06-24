// using System;
// using System.Collections.Generic;

// // 마지막 두 원소
// public class Q26
// {
//     public int[] solution(int[] num_list)
//     {
//         List<int> list = new List<int>(num_list);

//         int a = num_list[num_list.Length - 1];
//         int b = num_list[num_list.Length - 2];

//         if (a > b)
//         {
//             int big = a - b;
//             list.Insert(num_list.Length, big);
//         }
//         else
//         {
//             int small = a * 2;
//             list.Insert(num_list.Length, small);
//         }
//         return list.ToArray();
//     }
// }