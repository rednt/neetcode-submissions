public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        List<List<int>> ans = new List<List<int>>();

        for (int i = 0; i < nums.Length - 2; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right){
                int sum = nums[left] + nums[i] + nums[right];
                if (sum == 0){
                    ans.Add(new List<int> { nums[left], nums[i], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]){ left++; }
                    while (left < right && nums[right] == nums[right + 1]){ right--; }
                }
                else if (sum < 0){
                    left++;
                }
                else{
                    right--;
                }

            }
        }

        return ans;
    }
}

