
using System;
using System.Linq.Expressions;

public class SimpleVisitor : ExpressionVisitor
{
    protected override Expression VisitConstant(ConstantExpression node)
    {
        Console.WriteLine($"Constant: {node.Value}");
        return base.VisitConstant(node);
    }
}

public static class VisitExpressionExample
{
    public static void Run()
    {
        Console.WriteLine("-- Expression Visitor Example --");
        Expression<Func<int,int>> expr = x => (x + 2) * 5;
        new SimpleVisitor().Visit(expr);
        Console.WriteLine();
    }
}
