public class Solution {
    public bool hasDuplicate(int[] nums) {

        Dictionary<int, bool> seen = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++) {
            
            int number = nums[i];

            if (seen.ContainsKey(number) && seen[number] == true) {
                return true;
            } 
            else if (!seen.ContainsKey(number)) {
                seen.Add(number, true);
            }
        }

        return false;
    }
}