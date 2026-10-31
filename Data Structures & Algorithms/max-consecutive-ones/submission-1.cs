public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        Dictionary<int, int> onesCount = new Dictionary<int, int>();

        int count = 0;

        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] == 1)
                count++;
            
            if (nums[i] == 0 || i == nums.Length - 1)
            {
                if (!onesCount.ContainsKey(count))
                    onesCount.Add(count, i);
                count = 0;
            }
        }

        return onesCount.Keys.Max();
    }
}