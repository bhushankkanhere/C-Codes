using System;

class PalindromeStringRecursion {
    static bool IsPalindrome(string s, int l, int r) {
        if (l >= r) return true;
        if (s[l] != s[r]) return false;
        return IsPalindrome(s, l + 1, r - 1);
    }

    static void Main() {
        string str = "madam";
        Console.WriteLine(IsPalindrome(str, 0, str.Length - 1));
    }
}