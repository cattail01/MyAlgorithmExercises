public class Solution
{
    public bool IsValid(string s)
    {
        if(s.Length <= 0)
            return true;

        // 创建dic，记录左括号对应的右括号
        Dictionary<char, char> brackets = new Dictionary<char, char>();
        brackets.Add('(', ')');
        brackets.Add('[', ']');
        brackets.Add('{', '}');

        // 所有的右括号列表
        List<char> rightBrackets = new List<char>(brackets.Values);

        // 使用栈记录出现过的左括号
        Stack<char> remainLeftBrackets = new Stack<char>();

        foreach (char c in s)
        {
            // 如果检测到左括号
            if(brackets.ContainsKey(c))
                remainLeftBrackets.Push(c);

            // 如果检测到右括号
            else if(rightBrackets.Contains(c))
            {
                // 右括号比左括号多的情况
                // 如果左括号栈里没有东西，返回false
                if (remainLeftBrackets.Count == 0)
                    return false;

                // 从左括号堆栈中弹出左括号
                char leftBarcket = remainLeftBrackets.Pop();

                // 如果弹出的左括号和该右括号不相符，则返回false
                if (brackets[leftBarcket] != c)
                    return false;
            }
        }

        // 左括号比右括号多的情况
        // 如果左括号栈里还有东西，返回false
        if (remainLeftBrackets.Count != 0)
            return false;

        return true;
    }

    public static void Main(string[] args)
    {
        string s1 = "(){}[]";
        string s2 = "[{(...)}]";
        string s3 = "(]";
        string s4 = "(";
        string s5 = ")";
        Solution solution = new Solution();
        Console.WriteLine("{0}is{1}", s1, solution.IsValid(s1));
        Console.WriteLine("{0}is{1}", s2, solution.IsValid(s2));
        Console.WriteLine("{0}is{1}", s3, solution.IsValid(s3));
        Console.WriteLine("{0}is{1}", s4, solution.IsValid(s4));
        Console.WriteLine("{0}is{1}", s5, solution.IsValid(s5));

    }
}