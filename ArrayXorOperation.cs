namespace MyLeetCodeSolutions
{
    public class ArrayXorOperation
    {
        /// <summary>
        /// Given an integer n and an integer start.
        /// Define an array nums where nums[i] = start + 2 * i(0 - indexed) and n == nums.length.
        /// Return the bitwise XOR of all elements of nums.
        /// 
        /// Example:
        /// Input: n = 5, start = 0
        /// Output: 8
        /// Explanation: Array nums is equal to[0, 2, 4, 6, 8] where(0 ^ 2 ^ 4 ^ 6 ^ 8) = 8.
        /// Where "^" corresponds to bitwise XOR operator.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public int XorOperation(int n, int start)
        {
            var data = new int[n];
            for (var i = 0; i < n; i++) data[i] = start + 2 * i;

            var result = 0;
            foreach (int value in data)
            {
                result ^= value;
            }

            return result;
        }
    }
}
