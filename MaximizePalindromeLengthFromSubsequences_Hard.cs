using System;

namespace MyLeetCodeSulutions
{
    ///Runtime: 128 ms, faster than 100.00% of C# online submissions for Maximize Palindrome Length From Subsequences.
    /// <summary>
    /// You are given two strings, word1 and word2. You want to construct a string in the following manner:
    /// Choose some non-empty subsequence subsequence1 from word1.
    /// Choose some non-empty subsequence subsequence2 from word2.
    /// Concatenate the subsequences: subsequence1 + subsequence2, to make the string.
    /// Return the length of the longest palindrome that 
    /// can be constructed in the described manner.
    /// If no palindromes can be constructed, return 0.
    /// A subsequence of a string s is a string that can be made 
    /// by deleting some(possibly none) characters from s without 
    /// changing the order of the remaining characters.
    /// A palindrome is a string that reads the same forward as well as backward.
    /// </summary>
    public class MaximizePalindromeLengthFromSubsequences_Hard
    {
        public int LongestPalindrome(String word1, String word2)
        {
            var s = word1 + word2;
            var word1Length = word1.Length;
            var strLength = s.Length;
            var dp = new int[strLength, strLength];
            for (var i = 0; i < strLength; i++)
            {
                dp[i, i] = 1;
            }
            var result = 0;
            for (int i = strLength - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < strLength; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i, j] = dp[i + 1, j - 1] + 2;
                        if (i < word1Length && j >= word1Length)
                        {
                            result = Math.Max(result, dp[i, j]);
                        }
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);
                    }
                }
            }
            return result;
        }
    }
}
