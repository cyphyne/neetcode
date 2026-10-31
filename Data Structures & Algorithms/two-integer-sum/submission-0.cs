public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        int[] indices = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if (numbers.TryGetValue(difference, out var position))
            {
                if (position < i)
                {
                    indices[0] = position;
                    indices[1] = i;
                }
                else 
                {
                    indices[0] = i;
                    indices[1] = position;
                }
                break;
            }
            else 
            {
                numbers.Add(nums[i], i);
            }
        }

        return indices;
    }
}
