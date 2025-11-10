using System;
using System.Collections.Generic;

namespace algo_dsa.Array;
public class ArrayHashingDuplicates
{
    public bool HasDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
                return true; // Duplicate found
            seen.Add(num);
        }

        return false; // No duplicates found
    }
}
