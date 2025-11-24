
using System;
using System.Linq.Expressions;

public static class BuildTreeManuallyExample
{
    public static void Run()
    {
        Console.WriteLine("-- Manual Expression Tree --");
        var n = Expression.Parameter(typeof(int),"n");
        var mult = Expression.Multiply(n, Expression.Constant(10));
        var lambda = Expression.Lambda<Func<int,int>>(mult,n);
        Console.WriteLine(lambda);
        Console.WriteLine(lambda.Compile()(7));
        Console.WriteLine();
    }
}
