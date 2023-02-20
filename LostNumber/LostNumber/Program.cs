public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int[] length = new int[nums.Length + 1];
        foreach (int num in nums)
        {
            ++length[num];
        }

        return Array.IndexOf(length, 0);
    }

    public static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1 };
        Solution solution = new Solution();
        Console.WriteLine(solution.MissingNumber(nums));
    }
}
