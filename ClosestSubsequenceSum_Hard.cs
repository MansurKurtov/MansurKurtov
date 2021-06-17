using System;
using System.Collections.Generic;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// You are given an integer array nums and an integer goal.
    /// You want to choose a subsequence of nums such that the 
    /// sum of its elements is the closest possible to goal.
    /// That is, if the sum of the subsequence's elements is sum, 
    /// then you want to minimize the absolute difference abs(sum - goal).
    /// 
    /// Return the minimum possible value of abs(sum - goal).
    /// Note that a subsequence of an array is an array 
    /// formed by removing some elements(possibly all or none) of the original array.
    /// </summary>
    public class ClosestSubsequenceSum_Hard2
    {
        public int MinAbsDifference(int[] nums, int goal)
        {
            var data1 = new List<int>();
            var data2 = new List<int>();
            var l = nums.Length >> 1;
            getSum(data1, nums, 0, 0, l);
            getSum(data2, nums, 0, l, nums.Length);
            data1.Sort();
            data2.Sort();
            int i1 = 0, n1 = data1.Count, i2 = data2.Count - 1;
            int ans = Math.Abs(goal);
            while (i1 < n1 && i2 >= 0)
            {
                int num = data1[i1] + data2[i2] - goal;
                if (num > 0)
                {
                    i2--;
                    ans = Math.Min(ans, num);
                }
                else if (num < 0)
                {
                    i1++;
                    ans = Math.Min(ans, -num);
                }
                else
                    return 0;
            }
            return ans;
        }

        private void getSum(List<int> col, int[] nums, int sum, int i, int end)
        {
            if (i >= end)
            {
                col.Add(sum);
                return;
            }
            getSum(col, nums, sum + nums[i], i + 1, end);
            getSum(col, nums, sum, i + 1, end);
        }
    }
    class ClosestSubsequenceSum_Hard_Time_Litimt_Err
    {
        private int result = int.MaxValue;

        public int minAbsDifference(int[] nums, int goal)
        {
            Array.Sort(nums);
            var cur = new List<int>();
            var elementsCount = nums.Length;

            if (elementsCount <= 20)
            {
                Check(nums, goal, 0, 0, cur);
                return result;
            }

            var a = 0;
            var b = elementsCount - 1;
            var total = 0;
            for (var i = 0; i < elementsCount; i++)
                total += nums[i];

            while (a <= b && b > 0 && a < elementsCount)
            {
                if (b - a <= 18)
                {
                    int[] ar = new int[b - a + 1];
                    int k = 0;

                    for (int i = a; i <= b; i++)
                    {
                        ar[k++] = nums[i];
                    }

                    Check(ar, goal, 0, 0, cur);
                    return result;
                }

                if (total < goal)
                {
                    total -= nums[a];
                    a++;
                }
                else if (total > goal)
                {
                    total -= nums[b];
                    b--;
                }
                else
                {
                    result = 0;
                    break;
                }
                result = Math.Min(result, Math.Abs(total - goal));
            }
            result = Math.Min(result, Math.Abs(total - goal));

            return result;
        }

        private void Check(int[] nums, int goal, int id, int sum, List<int> cur)
        {
            if (id < 0 || id > nums.Length) return;
            result = Math.Min(result, Math.Abs(goal - sum));

            for (int i = id; i < nums.Length; ++i)
            {
                cur.Add(nums[i]);
                Check(nums, goal, i + 1, sum + nums[i], cur);
                cur.Remove(cur.Count - 1);
            }
        }
    }
    
}
