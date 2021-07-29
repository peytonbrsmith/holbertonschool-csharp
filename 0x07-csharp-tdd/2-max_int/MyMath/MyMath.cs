using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// operations class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// max method
        /// </summary>
        /// <param name="nums"></param>
        /// <returns> max int in nums</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count < 1)
            {
                return 0;
            }

            int max = nums[0];

            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
