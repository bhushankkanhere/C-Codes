
using System;

class CheckBinaryNumber {
    static void Main() {
        string str = "10101";
        bool isBinary = true;

        foreach (char c in str) {
            if (c != '0' && c != '1') {
                isBinary = false;
                break;
            }
        }

        Console.WriteLine(isBinary);
    }
}