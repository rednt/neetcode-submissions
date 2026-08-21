public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> storage = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(!storage.Add(nums[i])){
                return true;
            }
        }
        return false;
    }
}