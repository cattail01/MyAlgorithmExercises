public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // 记录公共前缀的长度
        int CommonPrefixLength = strs[0].Length;

        // 对字符串数组中的每一个字符串进行处理
        foreach (string str in strs)
        {
            if (CommonPrefixLength <= 0)
                return "";

            // 如果前缀公共部分长度大于被检测的字符串长度
            // 将公共部分长度削到和被检测字符串长度相同
            if(CommonPrefixLength > str.Length)
                CommonPrefixLength = str.Length;

            // 从前面得到的公共部分长度开始，从后向前检查
            for (int i = CommonPrefixLength - 1; i >= 0; --i)
            {
                if (strs[0][i] != str[i])
                    CommonPrefixLength = i;
            }
        }

        return strs[0].Substring(0, CommonPrefixLength);
    }

    public static void Main(string[] args)
    {
        string[] strs = { "cattail", "cat", "ca" };
        Solution solution = new Solution();
        string result = solution.LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }
}