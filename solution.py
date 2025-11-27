class Solution:
    def findMaxConsecutiveOnes(self, nums):
        cons = 0
        p = 0
        for n in nums:
            if n == 1:
                p += 1
                cons = max(cons, p)
            else:
                p = 0
        
        return cons
