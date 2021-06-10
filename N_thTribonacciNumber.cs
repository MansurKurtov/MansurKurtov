namespace MyLeetCodeSolutions
{
    /// <summary>
    /// The Tribonacci sequence Tn is defined as follows: 
    /// T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
    /// Given n, return the value of Tn.
    /// </summary>
    public class N_thTribonacciNumber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            var a = 0;
            var b = 1;
            var c = 1;
            for (var x = 3; x <= n; x++)
            {
                var s = a + b + c;
                a = b; b = c; c = s;
            }
            return c;
        }

        /// <summary>
        /// Tribonacci with recurtion, but very slow
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Tribonacci2(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            return Tribonacci2(n - 1) + Tribonacci2(n - 2) + Tribonacci2(n - 3);
        }
    }
}
