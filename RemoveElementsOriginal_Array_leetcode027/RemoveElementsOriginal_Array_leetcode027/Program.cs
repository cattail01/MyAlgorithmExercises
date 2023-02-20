public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int n = nums.Length;
        // left既是慢指针，也是数组有效数据的数量
        int left = 0;
        for (int right = 0; right < n; ++right)
        {
            if (nums[right] == val) continue;
            // 只需要保存该有效数据即可，无需交换数据
            nums[left] = nums[right];
            ++left;
        }
        return left;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = new int[] {1, 2, 3, 4, 5, 6, 1 };
        int result = solution.RemoveElement(nums, 1);
        Console.WriteLine(result);
        foreach (int i in nums)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}
