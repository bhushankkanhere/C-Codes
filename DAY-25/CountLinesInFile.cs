using System;
using System.IO;

class CountLinesInFile {
    static void Main() {
        File.WriteAllText("a.txt", "Line1\nLine2\nLine3");
        int count = File.ReadAllLines("a.txt").Length;
        Console.WriteLine(count);
    }
}