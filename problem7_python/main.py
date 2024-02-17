class Solution:
    def reverse(self, x: int) -> int:
        xString = str(x)
        stringLength = len(xString)
        result = ""
        for i in range(stringLength):
            if xString[i] != "-":
                result = xString[i] + result
                #print(result)
        
        if x < 0:
            x = int("-" + result)
            if x < -2147483647:
                x = 0
        else:
            x = int(result)
            if x > 2147483648:
                x = 0

        return x


sol = Solution()
result = sol.reverse(123)
print(result)
    
result = sol.reverse(-321)
print(result)
    
result = sol.reverse(1534236469)
print(result)