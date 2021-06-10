using System.Collections.Generic;

namespace MyLeetCodeSolutions
{
    public class ShiftGridSolution
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var res = new List<IList<int>>();
            for (var i = 0; i < grid.Length; i++)
            {
                var row = new List<int>();
                for (var j = 0; j < grid[0].Length; j++)
                {
                    row.Add(0);
                }
                res.Add(row);
            }

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    var pos = Shift(grid.Length, grid[0].Length, i, j, k);
                    res[pos[0]][pos[1]] = grid[i][j];
                }
            }

            return res;
        }

        private int[] Shift(int row, int column, int i, int j, int k)
        {
            if (j + k > column - 1)
            {
                i = i + ((j + k) / column);
                j = (j + k) % column;
                i = i % row;
            }
            else
            {
                j = j + k;
            }

            return new int[] { i, j };
        }
    }
}
