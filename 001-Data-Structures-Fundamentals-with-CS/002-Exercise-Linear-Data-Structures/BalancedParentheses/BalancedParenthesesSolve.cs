﻿namespace BalancedParentheses;

public class BalancedParenthesesSolve : ISolvable
{
    public bool AreBalanced(string parentheses)
    {
        if (string.IsNullOrEmpty(parentheses)
            || parentheses.Length % 2 == 1)
            return false;

        var openBrackets = new Stack<char>(parentheses.Length / 2);

        foreach (var currentBracket in parentheses)
        {
            char expectedCharacter = default;

            switch (currentBracket)
            {
                case ')':
                    expectedCharacter = '(';
                    break;

                case ']':
                    expectedCharacter = '[';
                    break;

                case '}':
                    expectedCharacter = '{';
                    break;

                default:
                    openBrackets.Push(currentBracket);
                    break;
            }

            if (expectedCharacter != default
                && openBrackets.Pop() != expectedCharacter)
                return false;
        }

        return openBrackets.Count == 0;
    }
}