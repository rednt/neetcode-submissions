public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int difference = 0;
        
        Dictionary<int, int> map = new Dictionary<int, int>();        
        for(int i = 0; i < nums.Length; i++){
            difference = target - nums[i];
            if(map.TryGetValue(difference, out int index)){
                return new int[] { index, i};
            }
            map[nums[i]] = i;
        }
        return new int[0];

}
}