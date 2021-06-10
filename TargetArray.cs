using System.Collections.Generic;

namespace MyLeetCodeSolutions
{
    /// <summary>
    /// Given two arrays of integers nums and index. Your task is to create target array under the following rules:
    /// Initially target array is empty.
    /// From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
    /// Repeat the previous step until there are no elements to read in nums and index.
    /// Return the target array.
    /// It is guaranteed that the insertion operations will be valid.
    /// </summary>
    public class TargetArray
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var result = new List<int>();
            for (var x = 0; x < index.Length; x++)
            {
                var i = index[x];
                result.Insert(i, nums[x]);
            }
            return result.ToArray();
        }
    }
}
