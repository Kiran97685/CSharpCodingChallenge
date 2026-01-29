using System;

namespace CSharpCodingChallenge
{
    internal class Day97_BalancedParentheses
    {
        public void CheckBalanced()
        {
            string input = "{[()]}";

            char[] stack = new char[input.Length];
            int top = -1;

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack[++top] = ch;
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (top == -1)
                    {
                        Console.WriteLine("Not Balanced");
                        return;
                    }

                    char open = stack[top--];

                    if (!IsMatching(open, ch))
                    {
                        Console.WriteLine("Not Balanced");
                        return;
                    }
                }
            }

            if (top == -1)
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
        }

        private bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
