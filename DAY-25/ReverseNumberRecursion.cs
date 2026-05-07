using System;

class ReverseNumberRecursion {
    static int Reverse(int n, int rev = 0) {
        if (n == 0) return rev;
        return Reverse(n / 10, rev * 10 + n % 10);
    }

    static void Main() {
        Console.WriteLine(Reverse(1234));
    }
}