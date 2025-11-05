using System;
using System.Collections.Generic;
using System.Text;
namespace algo_dsa.Array;

public class Anagram
{

    public bool AreAnagrams(string str1, string str2, bool ignoreCase = false, bool ignoreWhitespace = false)
    {
        if (str1 is null) throw new ArgumentNullException(nameof(str1));
        if (str2 is null) throw new ArgumentNullException(nameof(str2));

        // Normalize Unicode to a canonical form to make combining characters comparable
        string s1 = str1.Normalize(NormalizationForm.FormC);
        string s2 = str2.Normalize(NormalizationForm.FormC);

        if (ignoreWhitespace)
        {
            s1 = RemoveWhitespace(s1);
            s2 = RemoveWhitespace(s2);
        }

        if (ignoreCase)
        {
            // Use invariant to avoid culture-specific differences
            s1 = s1.ToUpperInvariant();
            s2 = s2.ToUpperInvariant();
        }

        if (s1.Length != s2.Length)
            return false;

        // Use dictionary to support the full range of char values safely
        var charCount = new Dictionary<char, int>(capacity: Math.Max(16, s1.Length));

        foreach (char c in s1)
        {
            if (charCount.TryGetValue(c, out int cnt))
                charCount[c] = cnt + 1;
            else
                charCount[c] = 1;
        }

        foreach (char c in s2)
        {
            if (!charCount.TryGetValue(c, out int cnt))
                return false;

            cnt--;
            if (cnt < 0)
                return false;

            if (cnt == 0)
                charCount.Remove(c);
            else
                charCount[c] = cnt;
        }

        return charCount.Count == 0;
    }

    private static string RemoveWhitespace(string input)
    {
        var sb = new StringBuilder(input.Length);
        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
                sb.Append(c);
        }
        return sb.ToString();
    }
}
