using System;

class RemoveCharacter {
    static void Main() {
        string str = "hello world";
        char ch = 'l';

        string result = "";
        foreach (char c in str)
            if (c != ch) result += c;

        Console.WriteLine(result);
    }
}