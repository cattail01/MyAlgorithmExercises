using System.ComponentModel;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        // 贪心的length
        int length = Math.Max(a.Length, b.Length);

        // 相加从个位开始，所以可以先将两个数字字符串倒置，便于计算
        List<char> aRev = new List<char>(a.Reverse());
        List<char> bRev = new List<char>(b.Reverse());

        // 存储结果的list，由于add是从前向后添加，所以也是倒着的
        List<char> resultList = new List<char>();

        // 表示是否需要进位
        bool carryBit = false;

        // 用于统计两个数相同的位置及进位三者中1的个数
        int oneCount = 0;

        for (int i = 0; i < length; ++i)
        {
            // 如果标记小于数字长度，且该位置的数字位1
            // oneCount + 1
            oneCount += (i < aRev.Count && aRev[i] == '1') ? 1 : 0;
            oneCount += (i < bRev.Count && bRev[i] == '1') ? 1 : 0;
            // 检查进位
            oneCount += carryBit ? 1 : 0;
            // 根据1的个数确定下一次是否需要进位
            carryBit = oneCount >= 2;
            // 根据1的个数判断该位的数字
            resultList.Add(oneCount % 2 == 0 ? '0' : '1');
            // 将1的个数归0方便下一位的计算
            oneCount = 0;
        }

        // 处理进位
        if (carryBit)
        {
            resultList.Add('1');
        }

        // 将结果list倒置，并转化位字符串输出
        resultList.Reverse();
        return new string(resultList.ToArray());
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s1 = "11";
        string s2 = "1";
        Console.WriteLine(solution.AddBinary(s1, s2));
    }
}
