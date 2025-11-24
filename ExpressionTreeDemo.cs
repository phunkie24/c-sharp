
using System;
using System.Linq;

public static class ExpressionTreeDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Expression Tree Demo --");
        IQueryable<string> q = new[] {"a","bb","ccc"}.AsQueryable();
        Console.WriteLine(q.Where(x=>x.Length>1).Expression);
        Console.WriteLine();
    }
}
