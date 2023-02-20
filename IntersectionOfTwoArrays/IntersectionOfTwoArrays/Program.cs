public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int i in nums1)
        {
            dic[i] = 0;
        }

        foreach (int i in nums2)
        {
            if (dic.ContainsKey(i))
            {
                dic[i] = 1;
            }
        }

        List<int> resultList = new List<int>();
        foreach (KeyValuePair<int, int> keyValuePair in dic)
        {
            if(keyValuePair.Value == 1)
                resultList.Add(keyValuePair.Key);
        }

        return resultList.ToArray();
    }
}
