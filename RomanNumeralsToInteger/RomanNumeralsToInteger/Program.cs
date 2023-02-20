public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        Dictionary<char, int> dic = new Dictionary<char, int>();
        SetDic(dic);
        List<int> ints = RomanToInts(s, dic);
        result = IntsToInt(ints);
        return result;
    }

    private void SetDic(Dictionary<char, int> dic)
    {
        dic.Add('I', 1);
        dic.Add('V', 5);
        dic.Add('X', 10);
        dic.Add('L', 50);
        dic.Add('C', 100);
        dic.Add('D', 500);
        dic.Add('M', 1000);
    }

    private List<int> RomanToInts(string s, Dictionary<char, int> dic)
    {
        List<int> resultList = new List<int>();
        foreach (char c in s)
        {
            resultList.Add(dic[c]);
        }
        return resultList;
    }

    private int IntsToInt(List<int> ints)
    {
        int result = 0;
        for (int i = ints.Count - 1; i >= 0; --i)
        {
            // 处理最后一个数据
            if (i + 1 == ints.Count)
            {
                result += ints[i];
                continue;
            }

            if (ints[i] < ints[i + 1])
            {
                result -= ints[i];
            }
            else
            {
                result += ints[i];
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        string str = "MCMXCIV";
        Solution solution = new Solution();
        Console.WriteLine(solution.RomanToInt(str));
    }
}
