// using System;

// // 조건 문자열
// public class Solution
// {
//     // 내 풀이
//     public int solution(string ineq, string eq, int n, int m)
//     {
//         int answer = 0;
//         if (ineq.Equals("<") && eq.Equals("="))
//         {
//             answer += n <= m ? 1 : 0;
//         }
//         else if (ineq.Equals("<") && eq.Equals("!"))
//         {
//             answer += n < m ? 1 : 0;
//         }
//         else if (ineq.Equals(">") && eq.Equals("="))
//         {
//             answer += n >= m ? 1 : 0;
//         }
//         else if (ineq.Equals(">") && eq.Equals("!"))
//         {
//             answer += n > m ? 1 : 0;
//         }
//         return answer;
//     }

//     // 더 나은 풀이
//     public int solution2(string ineq, string eq, int n, int m)
//     {
//         int answer = 0;
//         string s = ineq + eq;
//         if (s == ">=") return n >= m ? 1 : 0;
//         if (s == "<=") return n <= m ? 1 : 0;
//         if (s == ">!") return n > m ? 1 : 0;
//         if (s == "<!") return n < m ? 1 : 0;

//         return answer;
//     }
// }