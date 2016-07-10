using System.Collections.Generic;
using System.Linq;

namespace Check_for_balanced_parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool HasBalancedParentheses(string text)
        {
            if (text == null || text.Length < 2)
                return false;
            var stack = new Stack<char>();
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if ("({[".Contains(c))
                {
                    stack.Push(c);
                }
                else if (")}]".Contains(c))
                {
                    // If all the items has already been removed and paranthese is found
                    if (stack.Count == 0)
                        return false;
                    if ((c == ')' && stack.Pop() != '(') || (c == ']' && stack.Pop() != '[') || (c == '}' && stack.Pop() != '{'))
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
