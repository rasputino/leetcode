#include <iostream>
#include <string>

//slow solution
//class Solution {
//public:
//    bool isPalindrome(int x) {
//        if (x < 0) return false;
//        std::string str = std::to_string(x);
//        int half = str.size() / 2;
//        int even = str.size() % 2;
//        int odd = 1 - even;
//        for (std::string::size_type i = even; i < half+even; i++) {
//            //std::cout << str[i];
//            if (str[half - i - odd] != str[half + i])
//            {
//                return false;
//            }
//        }
//
//        return true;
//    }
//};

class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0) return false;
        int digits = NumDigits(x);
        int evalNum = (digits/2)+1;
        int rightBuffer = x;
        int leftBuffer = x;
        for (int i = 0; i < evalNum; i++)
        {
            int right = rightBuffer % 10;
            rightBuffer /= 10;
            int power = pow(10, digits - i - 1);
            int left = leftBuffer / power;
            leftBuffer -= power * left;
            if (right != left)
            {
                return false;
            }
        }

        return true;
    }

    //fastest way?
    int NumDigits(int x)
    {
        return (x < 10 ? 1 :
                    (x < 100 ? 2 :
                        (x < 1000 ? 3 :
                            (x < 10000 ? 4 :
                                (x < 100000 ? 5 :
                                    (x < 1000000 ? 6 :
                                        (x < 10000000 ? 7 :
                                            (x < 100000000 ? 8 :
                                                (x < 1000000000 ? 9 :
                                                    10)))))))));
    }
};

int main()
{
    std::cout << "Hello World!\n";
    Solution sol;
    bool result = sol.isPalindrome(123);
    std::cout << std::boolalpha << result << std::endl;
    result = sol.isPalindrome(12322);
    std::cout << std::boolalpha << result << std::endl;
    result = sol.isPalindrome(12321);
    std::cout << std::boolalpha << result << std::endl;
    result = sol.isPalindrome(1221);
    std::cout << std::boolalpha << result << std::endl;
}
