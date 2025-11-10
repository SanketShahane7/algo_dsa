using System;
using System.Text;
namespace algo_dsa.Array;

public class Anagram
{

    ///-- Robust anagram check with options --///
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

    ///-- Simple anagram check by sorting strings --///
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] sSort = s.ToCharArray();
        char[] tSort = t.ToCharArray();
        System.Array.Sort(sSort);
        System.Array.Sort(tSort);
        return sSort.SequenceEqual(tSort);
    }

    ///-- Anagram check using HashMap --///
    public bool IsAnagramHashMap(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
        }

        return countS.Count == countT.Count && !countS.Except(countT).Any();
    }

    ///-- Anagram check using fixed-size array --///
    public bool IsAnagramArray(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            Console.WriteLine($"After incrementing for {s[i]}: {string.Join(",", count)}");
            count[t[i] - 'a']--;
            Console.WriteLine($"After decrementing for {t[i]}: {string.Join(",", count)}");
        }

        foreach (int val in count)
        {
            if (val != 0)
            {
                return false;
            }
        }
        return true;
    }


}
