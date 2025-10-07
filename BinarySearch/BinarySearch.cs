using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.BinarySearch;

public class BinarySearch
{
    public int[] SearchArray { get; set; }

    public BinarySearch(int[] arr)
    {
        this.SearchArray = arr;
    }

    public int Search(int target)
    {
        int start = 0;
        int end = this.SearchArray.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (this.SearchArray[mid] == target)
            {
                return mid; // Target found
            }
            else if (this.SearchArray[mid] < target)
            {
                start = mid + 1; // Search in the right half
            }
            else
            {
                end = mid - 1; // Search in the left half
            }
        }

        return -1; // Target not found
    }
}