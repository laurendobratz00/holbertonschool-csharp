using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Public class operations</summary>
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            int m = nums[0];
            foreach (int value in nums)
            {
                if (value > m)
                {
                    m = value;
                }
            }
            return m;
        }
    }
}
