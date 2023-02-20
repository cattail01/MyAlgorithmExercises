public class Solution
{
    /// <summary>
    /// 合并两个有序数组，使最终数组非降序排序
    /// </summary>
    /// <param name="nums1">第一个数组，返回结果为该数组</param>
    /// <param name="m">第一个数组初始的有效长度（实际长度为 m + n ）</param>
    /// <param name="nums2">第二个数组</param>
    /// <param name="n">第二个数组的长度</param>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int rp = nums1.Length - 1;
        int cache = 0;
        while (p1 >= 0 || p2 >= 0)
        {
            if(p1 == -1)    cache = nums2[p2--];
            else if(p2 == -1) cache = nums1[p1--];
            else if (nums1[p1] > nums2[p2]) cache = nums1[p1--];
            else cache = nums2[p2--];
            nums1[rp--] = cache;
        }
    }

    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        Solution solution = new Solution();
        solution.Merge(nums1, nums1.Length - nums2.Length, nums2, nums2.Length);
        foreach (int i in nums1)
        {
            Console.WriteLine(i);
        }
    }
}