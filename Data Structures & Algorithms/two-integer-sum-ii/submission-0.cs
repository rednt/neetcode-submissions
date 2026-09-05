public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int leftIndex = numbers.Length - 1;
        int rightIndex = 0;

        while (rightIndex < leftIndex){
            int sum = numbers[rightIndex] + numbers[leftIndex];
            if (sum == target){
                return new int[] { rightIndex + 1, leftIndex + 1 };
            }
            else if (sum > target){
                leftIndex--;
            }
            else{
                rightIndex++;
            }
            
        }
        return new int[] { -1,-1 };
    }
}
