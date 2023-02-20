public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int matXLength = mat.Length;
        int matYLength = mat[0].Length;
        if (matXLength * matYLength != r * c)
            return mat;
        int[][] result = new int[r][];
        for (int i = 0; i < r; ++i)
        {
            result[i] = new int[c];
        }
        // 对原始数组的每个元素进行遍历
        // 插入到新数组中
        int resultXPointer = 0;
        int resultYPointer = 0;
        for (int i = 0; i < matXLength; ++i)
        {
            for (int j = 0; j < matYLength; ++j)
            {
                result[resultXPointer][resultYPointer++] = mat[i][j];
                if (resultYPointer >= c)
                {
                    ++resultXPointer;
                    resultYPointer = 0;
                }
            }
        }
        return result;
    }
}

