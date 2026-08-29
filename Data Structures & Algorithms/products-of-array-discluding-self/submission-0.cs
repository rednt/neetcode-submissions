public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int arrLen = nums.Length;
        int[] ans = new int[arrLen];

        ans[0] = 1;
        for(int i = 1; i < arrLen; i++){
            ans[i] = ans[i - 1] * nums[i - 1];
        }
    
        int suffix = 1;
        for(int i = arrLen - 1; i >= 0; i--){
            ans[i] *= suffix;
            suffix *= nums[i]; 
        }

        return ans;
    }
}
