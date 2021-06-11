namespace MyLeetCodeSolutions
{
    public class BalancedString
    {
        /// <summary>
        /// Split a String in Balanced Strings
        /// Given a balanced string s, split it in the maximum amount of balanced strings.
        /// Return the maximum amount of split balanced strings.
        /// 
        /// Example 1:
        /// Input: s = "RLRRLLRLRL"
        /// Output: 4
        /// Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
        /// </summary>
        public int BalancedStringSplit(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var a = 0;
            var result = 0;
            foreach (var ch in s)
            {
                if (ch == 'L') a++;
                else a--;
                if (a == 0)
                    result++;
            }
            return result;
        }
    }
}
