using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> logs = new List<int>
        {
            101, 102, 103, 101, 104, 105, 102, 101
        };

        HashSet<int> uniqueUsers = new HashSet<int>();

        foreach (int userId in logs)
        {
            uniqueUsers.Add(userId);
        }

        int repeatEntries = logs.Count - uniqueUsers.Count;

        Console.WriteLine($"Log entries: {logs.Count}");
        Console.WriteLine($"Unique visitors: {uniqueUsers.Count}");
        Console.WriteLine($"Repeat entries: {repeatEntries}");
    }
}