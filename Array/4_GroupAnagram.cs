

public class GroupAnagrams
{
    ///-- Time Complexity: O(N * K) where N is the number of strings and K is the maximum length of a string.
    public List<List<string>> GroupAnagramsHashMap(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach (char c in s)
                count[c - 'a']++;

            string key = string.Join(",", count);
            if (!res.ContainsKey(key))
                res[key] = new List<string>();

            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }

    ///-- Time Complexity: O(N * K log K) where N is the number of strings and K is the maximum length of a string.
    public List<List<string>> GroupAnagramsSort(string[] strs)
    {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            if (!res.ContainsKey(sortedS))
                res[sortedS] = new List<string>();

            res[sortedS].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}