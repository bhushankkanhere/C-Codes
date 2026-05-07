using System;

class PowerUsingRecursion {
    static int Power(int a, int b) {
        if (b == 0) return 1;
        return a * Power(a, b - 1);
    }

    static void Main() {
        Console.WriteLine(Power(2, 5));
    }
}