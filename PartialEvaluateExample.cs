
using System;
using System.Linq.Expressions;

public static class PartialEvaluateExample
{
    public static void Run()
    {
        Console.WriteLine("-- Partial Evaluation Example --");
        int factor = 10;
        Expression<Func<int,int>> expr = x => x * factor;
        Console.WriteLine(expr);
        Console.WriteLine(expr.Compile()(3));
        Console.WriteLine();
    }
}
