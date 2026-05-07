using System;

class SimpleInterestFunction {
    static double SI(double p, double r, double t) {
        return (p * r * t) / 100;
    }

    static void Main() {
        Console.WriteLine(SI(1000, 5, 2));
    }
}