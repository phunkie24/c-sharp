using System;

public static class ExamplesRunner
{
    public static void RunAll()
    {
        IQueryableVsIEnumerableExample.Run();
        ExpressionTreeDemo.Run();
        ExpressionLambdaExample.Run();
        BuildTreeManuallyExample.Run();
        DynamicQueryExample.Run();
        IQueryableIncrementalBuildExample.Run();
        LinqToXmlExample.Run();
        VisitExpressionExample.Run();
        PartialEvaluateExample.Run();
    }
}
