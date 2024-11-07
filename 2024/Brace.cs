using Xunit;

namespace _2024;
using System;
using System.Collections.Generic;

/**
Write a function that takes a string of braces, and determines if the order of the braces is valid. 
It should return true if the string is valid, and false if it's invalid.
This Kata is similar to the Valid Parentheses Kata, but introduces new characters: 
brackets [], and curly braces {}. Thanks to @arnedag for the idea!
All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.
What is considered Valid?
A string of braces is considered valid if all braces are matched with the correct brace.

Examples

        "(){}[]"   =>  True
        "([{}])"   =>  True
        "(}"       =>  False
        "[(])"     =>  False
        "[({})](]" =>  False
 */
public static class Brace
{
    public static bool ValidBraces(string braces)
    {
        // Stack to keep track of opening braces
        var stack = new Stack<char>();

        // Dictionary to match opening and closing braces
        var matchingBraces = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        foreach (var brace in braces)
        {
            // If it's an opening brace, push it onto the stack
            if (matchingBraces.ContainsKey(brace))
                stack.Push(brace);
            else
            {
                // If it's a closing brace, check if it matches the top of the stack
                if (stack.Count == 0 || matchingBraces[stack.Pop()] != brace)
                    return false; // Invalid if there's no match
            }
        }

        // Valid if the stack is empty at the end
        return stack.Count == 0;
    }
}

public class BraceTests {

    [Fact]
    public void Test1() 
        => Assert.True(Brace.ValidBraces( "()" ));
    [Fact]
    public void Test2()
        => Assert.False(Brace.ValidBraces("[(])"));
}