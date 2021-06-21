using System.Text;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// 402. Remove K Digits
    /// Given string num representing a non-negative integer num, 
    /// and an integer k, return the smallest possible integer after removing k digits from num.
    /// 
    /// Example 1:
    /// Input: num = "1432219", k = 3
    /// Output: "1219"
    /// Explanation: Remove the three digits 4, 3, and 2 to 
    /// form the new number 1219 which is the smallest.
    /// </summary>
    internal class RemoveKdigitsFromString
    {
        public static string RemoveKdigits(string num, int k)
        {
            var n = num.Length;
            var stBuilder = new StringBuilder();
            if (n == 0 || n == k)
                return "0";
            stBuilder.Append(num[0]);
            var i = 1;
            while (i < n && k > 0)
            {
                while (stBuilder.Length != 0 && num[i] < stBuilder[stBuilder.Length - 1] && k > 0)
                {
                    stBuilder.Remove(stBuilder.Length - 1, 1);
                    k--;
                }
                stBuilder.Append(num[i]);
                i++;
            }

            while (k > 0 && stBuilder.Length > 0)
            {
                stBuilder.Remove(stBuilder.Length - 1, 1);
                k--;
            }

            for (int j = i; j < n; j++)
                stBuilder.Append(num[j]);

            var a = 0;
            while (a < stBuilder.Length && stBuilder.Length > 1)
            {
                if (stBuilder[a] == '0')
                    stBuilder.Remove(a, 1);
                else
                    break;
            }

            return stBuilder.Length == 0 ? "0" : stBuilder.ToString();
        }
    }
}
