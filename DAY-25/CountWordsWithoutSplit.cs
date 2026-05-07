using System;

class CountWordsWithoutSplit {
    static void Main() {
        string str = "C sharp is powerful";
        int count = 1;

        foreach (char c in str)
            if (c == ' ') count++;

        Console.WriteLine(count);
    }
}