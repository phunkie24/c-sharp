
using System;
using System.Linq;
using System.Collections.Generic;

public static class IQueryableIncrementalBuildExample
{
    public static void Run()
    {
        Console.WriteLine("-- IQueryable Incremental Build --");
        IQueryable<int> q = new List<int>{5,12,17,22}.AsQueryable();

        q = q.Where(x=>x>10);
        q = q.Where(x=>x<20);

        Console.WriteLine(string.Join(", ", q));
        Console.WriteLine();
    }
}
