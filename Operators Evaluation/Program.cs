using System;
using System.Collections.Generic;
using System.Linq;

namespace Operators_Evaluation
{
    class Program
    {
        // EXPREION: { (2 * 3 ) + ( 5 * 4 ) } - 9

        /* Post Fix
        *  { (23*) + (54*) } - 9
        * { (23*) (54*) + } - 9
        * { (23*) (54*) + 9-
         * 23*54*+9-
        */

        /*Pre Fix:
         * 
         * { ( *23 ) + ( *54 ) } - 9
         * { +( *23 ) ( *54 ) } - 9
         * { -+( *23 ) ( *54 ) } 9
         * -+*23*549
         */

        static void Main(string[] args)
        {
            const string exp = "23*54*+9-"; // the result should be 17
            Console.WriteLine("The result of expresion: {0} is: {1}", exp, EvaluatePostFix(exp));
            Console.ReadLine();
        }
        static int EvaluatePostFix(string expresion)
        {
            const string operators = "*/+-";

            var stack = new Stack<int>();
            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];
                if (char.IsDigit(c))
                {
                    int val = int.Parse(expresion[i].ToString());
                    stack.Push(val);
                }
                else if (operators.Contains(c))
                {
                    int rightoperand = stack.Pop();
                    int leftOperat = stack.Pop();
                    //var @out = 
                    stack.Push(PerformOperation(c, leftOperat, rightoperand));
                }
            }
            return stack.Pop();
        }
        static int PerformOperation(char op, int leftoperand, int rightoperand)
        {
            var result = 0;
            switch (op)
            {
                case '*':
                    result = leftoperand * rightoperand;
                    break;
                case '/':
                    result = leftoperand / rightoperand; // should check division by zero
                    break;
                case '-':
                    result = leftoperand - rightoperand;
                    break;
                case '+':
                    result = leftoperand + rightoperand;
                    break;
            }
            return result;
        }

        // TODO: EvaluatePostFix
    }
    static class ExtensionMethods
    {
        public static bool Contains(this string s, char c)
        {
            return s.Length > 0 && s.IndexOf(c) >= 0;
        }
    }
}
