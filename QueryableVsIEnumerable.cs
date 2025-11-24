
using System;
using System.Linq;
using System.Collections.Generic;

public static class IQueryableVsIEnumerableExample
{
    public static void Run()
    {
        Console.WriteLine("-- IQueryable vs IEnumerable --");
        IQueryable<int> q = new List<int> {1,2,3,4}.AsQueryable();
        IEnumerable<int> e = new List<int> {1,2,3,4};

        Console.WriteLine(q.Expression);
        foreach(var n in e.Where(x=>x>2))
            Console.WriteLine(n);
        Console.WriteLine();
    }
}
