class Solution {
    public int findMaxConsecutiveOnes(int[] nums) {
        int cons = 0;
        int p = 0;
        for(int i = 0; i < nums.length; i++){
            if(nums[i] == 1){
                p++;
            }
            else{
                cons = Math.max(cons, p);
                p = 0;
            }
        }

        return(Math.max(cons, p));
    }
}
