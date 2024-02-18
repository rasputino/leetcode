class Solution:
    def myAtoi(self, s: str) -> int:
        
        index = 0
        digitAppeared = False
        
        for c in s:
            if c.isdigit():
                digitAppeared = True
            elif c.isspace():
                if digitAppeared:
                    break
            elif c == "+" or c == "-":
                if digitAppeared:
                    break
                digitAppeared = True
            elif c.isprintable():
                break
                        
            index = index + 1
        
        power = 0
        result = 0
        for i in range(index-1, -1, -1):
            c = s[i]
            
            if c.isdigit():
                val = int(c)
                result = result + (pow(10, power) * val)
                power = power + 1
            elif c == "-":
                result = result * -1
            elif c == " ":
                pass
            
        if result < -2147483648:
            return -2147483648
        elif result > 2147483647:
            return 2147483647
        
        return result

sol = Solution()
print(sol.myAtoi("   +0 123"))
print(sol.myAtoi("00000-42a1234"))
print(sol.myAtoi("    -42"))
print(sol.myAtoi("   -321"))
print(sol.myAtoi("123 with words"))
print(sol.myAtoi("word 123"))
print(sol.myAtoi("+-123"))
print(sol.myAtoi("-+123"))
print(sol.myAtoi("3.141592"))
print(sol.myAtoi("+"))
