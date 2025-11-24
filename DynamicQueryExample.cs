
using System;
using System.Linq;
using System.Linq.Expressions;

public static class DynamicQueryExample
{
    public static IQueryable<T> AddEqualsClause<T>(IQueryable<T> src,string prop,object value)
    {
        var param = Expression.Parameter(typeof(T),"x");
        var property = Expression.Property(param, prop);
        var constant = Expression.Constant(value);
        var eq = Expression.Equal(property, constant);
        var lambda = Expression.Lambda<Func<T,bool>>(eq, param);
        return src.Where(lambda);
    }

    public static void Run()
    {
        Console.WriteLine("-- Dynamic Query Example --");
        var data = new[]
        {
            new { Name="Tom", Age=30 },
            new { Name="Dick", Age=40 },
            new { Name="Harry", Age=40 }
        }.AsQueryable();

        var q = AddEqualsClause(data, "Age", 40);
        foreach(var item in q) Console.WriteLine(item);
        Console.WriteLine();
    }
}
