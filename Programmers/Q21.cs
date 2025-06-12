// using System;

// // 코드 처리하기
// public class Q21
// {
//     public string solution(string code)
//     {
//         string answer = "";
//         int mode = 0;

//         for (int i = 0; i < code.Length; i++)
//         {
//             if (mode == 0)
//             {
//                 if (code[i] != '1' && i % 2 == 0)
//                     answer += code[i];
//                 else if (code[i] == '1')
//                     mode = 1;
//             }
//             else if (mode == 1)
//             {
//                 if (code[i] != '1' && i % 2 != 0)
//                     answer += code[i];
//                 else if (code[i] == '1')
//                     mode = 0;
//             }
//         }
//         if (answer == "") return "EMPTY";
//         return answer;
//     }
// }