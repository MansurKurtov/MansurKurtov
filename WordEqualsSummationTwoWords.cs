namespace MyLeetCodeSulutions
{
    public class WordEqualsSummationTwoWords
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            var a = GetAsciiSum(firstWord);
            var b = GetAsciiSum(secondWord);
            var c = GetAsciiSum(targetWord);
            return a + b == c;
        }
        private int GetAsciiSum(string s)
        {
            var d = 0;
            foreach (var item in s)
            {
                var code = (int)item - 97;
                d = d * 10 + code;
            }
            return d;
        }
    }
}
