public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int result = s.Length;

        for (int i = result - 1; i >= 0; --i)
        {
            //if (s[i] == ' ')
            if (char.IsWhiteSpace(s[i]))
            {
                result = result - i - 1;
                break;
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        string s = "   fly me   to   the moon ";
        Solution solution = new Solution();
        Console.WriteLine(solution.LengthOfLastWord(s));
    }
}
