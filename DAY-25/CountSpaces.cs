using System;

class CountSpaces {
    static void Main() {
        string str = "C sharp language";
        int count = 0;

        foreach (char c in str)
            if (c == ' ') count++;

        Console.WriteLine(count);
    }
}