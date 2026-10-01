using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> amitSkills = new HashSet<string>
        {
            "C#", "SQL", "Python"
        };

        HashSet<string> priyaSkills = new HashSet<string>
        {
            "C#", "SQL", "React", "Azure"
        };

        HashSet<string> shared = new HashSet<string>(amitSkills);
        shared.IntersectWith(priyaSkills);

        HashSet<string> onlyAmit = new HashSet<string>(amitSkills);
        onlyAmit.ExceptWith(priyaSkills);

        HashSet<string> allSkills = new HashSet<string>(amitSkills);
        allSkills.UnionWith(priyaSkills);

        Console.WriteLine(
            "Shared: " + string.Join(", ", shared)
        );

        Console.WriteLine(
            "Only Amit: " + string.Join(", ", onlyAmit)
        );

        Console.WriteLine(
            "All skills: " + string.Join(", ", allSkills)
        );
    }
}