
using System;
using System.Linq.Expressions;

public static class ExpressionLambdaExample
{
    public static void Run()
    {
        Console.WriteLine("-- Expression<T> Example --");
        Expression<Func<int,int>> expr = n => n * 10;
        Console.WriteLine(expr.Compile()(5));
        Console.WriteLine(expr.Body);
        Console.WriteLine();
    }
}
