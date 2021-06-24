namespace MyLeetCodeSulutions
{
    /// <summary>
    /// 43. Multiply Strings
    /// Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
    /// Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.
    /// Example 1:
    /// Input: num1 = "2", num2 = "3"
    /// Output: "6"
    /// Example 2:
    /// Input: num1 = "123", num2 = "456"
    /// Output: "56088"
    /// Constraints:
    /// 1 <= num1.length, num2.length <= 200
    /// num1 and num2 consist of digits only.
    /// Both num1 and num2 do not contain any leading zero, except the number 0 itself.
    /// </summary>
    public class MultiplyTwoStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (num1.Equals("0") || num2.Equals("0"))
                return "0";

            if (num1.Length < num2.Length)
            {
                var tmp = num1;
                num1 = num2;
                num2 = tmp;
            }

            while (num2.Length != num1.Length) num2 = '0' + num2;
            var q = 0;
            var a = 0;
            var b = 0;
            var c = 0;
            var d = 0;
            var s = string.Empty;
            var result = string.Empty;
            var p = string.Empty;
            for (var x = num1.Length - 1; x >= 0; x--)
            {
                s = string.Empty; q = 0;
                a = int.Parse(num1[x].ToString());
                for (var y = num2.Length - 1; y >= 0; y--)
                {
                    b = int.Parse(num2[y].ToString());
                    c = a * b + q;
                    q = c / 10;
                    d = c % 10;
                    s = d.ToString() + s;
                }
                if (q != 0) s = q.ToString() + s;

                result = Add(result, s + p);
                p += '0';
            }

            while (result[0] == '0')
                result = result.Remove(0, 1);

            return result;
        }

        private string Add(string st1, string st2)
        {
            if (string.IsNullOrEmpty(st1))
                return st2;

            while (st1.Length != st2.Length) st1 = '0' + st1;
            var a = 0;
            var b = 0;
            var c = 0;
            var q = 0;
            var d = 0;
            var s = string.Empty;
            for (var i = st2.Length - 1; i >= 0; i--)
            {
                a = int.Parse(st1[i].ToString());
                b = int.Parse(st2[i].ToString());
                c = a + b + q;
                q = c / 10;
                d = c % 10;
                s = d.ToString() + s;
            }
            if (q != 0) s = q.ToString() + s;
            return s;
        }
    }
}
