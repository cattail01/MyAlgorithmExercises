public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int iLength = grid.Length;
        int jLength = grid[0].Length;
        int sumLength = 0;
        // 对第一个长横边进行判断
        for (int j = 0; j < jLength; ++j)
        {
            if (grid[0][j] == 1)
                ++sumLength;
        }

        // 对其余长横边进行判断
        for (int i = 1; i < iLength; ++i)
        {
            for (int j = 0; j < jLength; ++j)
            {
                if (grid[i][j] != grid[i - 1][j])
                {
                    ++sumLength;
                }
            }
        }

        // 对最后一个长横边进行判断
        for (int j = 0; j < jLength; ++j)
        {
            if (grid[iLength - 1][j] == 1)
            {
                ++sumLength;
            }
        }

        // 对长纵边也来一遍
        for (int i = 0; i < iLength; ++i)
        {
            if (grid[i][0] == 1)
            {
                ++sumLength;
            }
        }

        for (int j = 1; j < jLength; ++j)
        {
            for (int i = 0; i < iLength; ++i)
            {
                if (grid[i][j] != grid[i][j - 1])
                {
                    ++sumLength;
                }
            }
        }

        for (int i = 0; i < iLength; ++i)
        {
            if (grid[i][jLength - 1] == 1)
            {
                ++sumLength;
            }
        }

        return sumLength;
    }

    public static void Main(string[] args)
    {
        int[][] grid = new[]
        {
            new[] { 0, 1, 0, 0 },
            new[] { 1, 1, 1, 0 },
            new[] { 0, 1, 0, 0 },
            new[] { 1, 1, 0, 0 }
        };
        Solution solution = new Solution();
        Console.WriteLine(solution.IslandPerimeter(grid));
    }
}