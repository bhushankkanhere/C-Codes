using System;

class CountSetBits {
    static void Main() {
        int n = 13, count = 0;

        while (n > 0) {
            count += n & 1;
            n >>= 1;
        }

        Console.WriteLine(count);
    }
}