using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algo_dsa.BubbleSort;

public class BubbleSort
{

    public static int[] Sort(int[] arr)
    {
        //-- Hold temp swap value
        int temp = 0;
        
        //-- Iterate through the array
        for (int pointer = 0; pointer < arr.Length - 1; pointer++)
        {
            //-- Iterate through the array again for comparison
            for (int sort = 0; sort < arr.Length - 1 - pointer; sort++)
            {
                //-- Compare current index with next index
                //-- If current index is greater than next index, swap values
                if (arr[sort] > arr[sort + 1])
                {
                    //-- Store current index value in temp
                    temp = arr[sort];
                    //-- Assign next index value to current index
                    arr[sort] = arr[sort + 1];
                    //-- Assign temp value to next index
                    arr[sort + 1] = temp;
                }
            }
        }

        return arr;
    }

}
