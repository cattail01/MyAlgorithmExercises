public class Solution
{
    private int[] elements = new int[9];

    public int[][] ImageSmoother(int[][] img)
    {
        int imgXLength = img.Length;
        int imgYLength = img[0].Length;
        int[][] result = new int[imgXLength][];
        for (int i = 0; i < imgXLength; ++i)
        {
            result[i] = new int[imgYLength];
        }

        for (int i = 0; i < imgXLength; ++i)
        {
            for (int j = 0; j < imgYLength; ++j)
            {
                result[i][j] = ImageSmooterForEachElement(img, i, j);
            }
        }
        return result;
    }

    private int ImageSmooterForEachElement(int[][] img, int iImg, int jImg)
    {
        
        int elementPointer = 0;
        int iLength = img.Length;
        int jLength = img[0].Length;
        for (int i = -1; i < 2; ++i)
        {
            if(iImg + i >= 0 && iImg + i < iLength)
            {
                for (int j = -1; j < 2; ++j)
                {
                    if (jImg + j >= 0 && jImg + j < jLength)
                    {
                        elements[elementPointer++] = img[iImg + i][jImg + j];
                    }
                }
            }
        }

        int result = elements.Sum() / elementPointer;
        Array.Clear(elements);
        return result;
    }

    public static void Main(string[] args)
    {
        int[][] img = new[]
        {
            new[] { 100,200,100 },
            new[] { 200,50,200 },
            new[] { 100, 200, 100 }
        };
        Solution solution = new Solution();
        var result = solution.ImageSmoother(img);
        for (int i = 0; i < result.Length; ++i)
        {
            for (int j = 0; j < result[0].Length; ++j)
            {
                Console.Write(result[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
dotnet tool install -g --add-source "https://api.nuget.org/v3/index.json" --ignore-failed-sources upgrade-assistant
