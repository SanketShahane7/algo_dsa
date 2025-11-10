public class TwoSum
{
    public int[] FindTwoSum(int[] numbers, int target)
    {
        ///-- With Brute Force
        // for (int i = 0; i < nums.Length; i++) {
        //     var val1 = nums[i];
        //     for (int j = i+1; j < nums.Length; j++) {
        //         var val2 = nums[j];
        //         // Console.WriteLine($"Value 1: {val1} and Value 2: {val2} and Sum of both will be {val1+val2}");
        //         var sum = val1 + val2;
        //         if (sum == target)
        //             return new int[] { i, j };
        //     }
        // }
        // return new int[] {0, 1};

        ///-- With Hashing
        var numDict = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if (numDict.ContainsKey(complement))
                return new int[] { numDict[complement], i };

            numDict[numbers[i]] = i;
        }
        return Array.Empty<int>(); // No two sum solution found
    }
}
