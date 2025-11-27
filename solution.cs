public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int cons = 0;
        int p = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                p++;
            }
            else{
                cons = Math.Max(cons, p);
                p = 0;
            }
        }

        return(Math.Max(cons, p));
    }
}
