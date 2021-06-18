using System.Collections.Generic;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// A valid parentheses string is either empty "", "(" + A + ")", or A + B, 
    /// where A and B are valid parentheses strings, and + represents string concatenation.
    /// For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.
    /// A valid parentheses string s is primitive if it is nonempty, and there does 
    /// not exist a way to split it into s = A + B, with A and B 
    /// nonempty valid parentheses strings.
    /// Given a valid parentheses string s, consider its primitive 
    /// decomposition: s = P1 + P2 + ... + Pk, where Pi are primitive valid parentheses strings.
    /// Return s after removing the outermost parentheses of every primitive string in the primitive decomposition of s.
    /// </summary>
    public class RemoveOutermostParentheses_Fast
    {
        public static string RemoveOuterParentheses(string s)
        {
            var a = 0;
            var indexs = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    a++;
                else if (s[i] == ')')
                    a--;
                if (indexs.Count % 2 == 0 && a == 1)
                    indexs.Add(i + 1);
                else if (indexs.Count % 2 != 0 && a == 0)
                    indexs.Add(i);
            }
            var result = string.Empty;
            for (int i = 0; i < indexs.Count; i += 2)
            {
                result += s.Substring(indexs[i], indexs[i + 1] - indexs[i]);
            }
            return result;
        }
    }

}
