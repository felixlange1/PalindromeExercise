using System;

namespace PalindromeExerciseTests;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        string reversed = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        if (reversed == word) return true;
        return false;
    }
}