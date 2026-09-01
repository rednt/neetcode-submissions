public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);
        int longestSequence = 0;

        foreach (int num in numSet){
            if (!numSet.Contains(num - 1)){
                int currNum = num;
                int currStreak = 1;
            
                while (numSet.Contains(currNum + 1)){
                    currNum++;
                    currStreak++;
                }
                longestSequence = Math.Max(longestSequence, currStreak);
            }
        }

        return longestSequence;
    }
}
