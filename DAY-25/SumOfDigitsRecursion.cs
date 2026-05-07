using System;

class SumOfDigitsRecursion {
    static int Sum(int n) {
        if (n == 0) return 0;
        return n % 10 + Sum(n / 10);
    }

    static void Main() {
        Console.WriteLine(Sum(1234));
    }
}