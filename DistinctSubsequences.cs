namespace MyLeetCodeSulutions
{
    /// <summary>
    /// Given two strings s and t, return the number of distinct subsequences of s which equals t.
    /// A string's subsequence is a new string formed from the original string by deleting some (can be none) of 
    /// the characters without disturbing the remaining characters' 
    /// relative positions. (i.e., "ACE" is a subsequence of "ABCDE" while "AEC" is not).
    /// It is guaranteed the answer fits on a 32-bit signed integer
    /// 
    /// Example:
    /// Input: s = "rabbbit", t = "rabbit"
    /// Output: 3
    /// Explanation:
    /// As shown below, there are 3 ways you can generate "rabbit" from S.
    /// rabbbit
    /// rabbbit
    /// rabbbit
    /// </summary>
    public class DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return default;


            var lens = s.Length;
            var lent = t.Length;

            var dp = new int[lens + 1, lent + 1];
            dp[0, 0] = 1;
            for (int i = 0; i < lens; i++)
            {
                dp[i + 1, 0] = 1;
            }

            for (int i = 1; i <= lens; i++)
            {
                for (int j = 1; j <= lent; j++)
                {
                    if (s[i - 1].Equals(t[j - 1]))
                    {
                        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[lens, lent];
        }
    }
