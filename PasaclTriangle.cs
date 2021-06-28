using System.Collections.Generic;
using System.Linq;

namespace MyLeetCodeSulutions
{
    /// <summary>
    /// 118. Pascal's Triangle
    /// Given an integer numRows, return the first numRows of Pascal's triangle.
    /// 
    /// Example 1:
    /// Input: numRows = 5
    /// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    /// 
    /// Example 2:
    /// Input: numRows = 1
    /// Output: [[1]]
    /// </summary>
    public class PasaclTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var item1 = new List<int>();
            item1.Add(1);
            result.Add(item1);

            if (numRows == 1)
                return result;

            var item2 = new List<int>();
            item2.Add(1);
            item2.Add(1);
            result.Add(item2);

            if (numRows == 2)
                return result;

            var i = 2;
            while (i != numRows)
            {
                var data = result.Last().ToArray();
                var n = data.Length;
                var item = new int[n + 1];
                item[0] = 1;
                item[n] = 1;
                for (var x = 1; x < n; x++)
                    item[x] = data[x - 1] + data[x];
                result.Add(item); i++;
            }

            return result;
        }
    }
}
