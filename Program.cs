<<<<<<< HEAD
using System;

namespace LinqCompleteProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== LINQ COMPLETE PROJECT ===");
            ExamplesRunner.RunAll();
=======
﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqProject
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            Console.WriteLine("=== Fluent Syntax ===");
            IEnumerable<string> fluentQuery = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (var name in fluentQuery)
                Console.WriteLine(name);

            Console.WriteLine("\n=== Query Expression Syntax ===");
            IEnumerable<string> querySyntax =
                from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();

            foreach (var name in querySyntax)
                Console.WriteLine(name);

            Console.WriteLine("\n=== Deferred Execution Demo ===");
            var numbers = new List<int> { 1 };
            var query = numbers.Select(n => n * 10); // Query not executed yet
            numbers.Add(2); // Will be included when enumerated

            foreach (var n in query)
                Console.WriteLine(n); // Output: 10, 20

            Console.WriteLine("\n=== Subquery Example ===");
            IEnumerable<string> shortestNames =
                from n in names
                where n.Length == names.Min(x => x.Length)
                select n;

            foreach (var n in shortestNames)
                Console.WriteLine(n); // Tom, Jay
>>>>>>> 2af17809846db5a933cae6aa279d62a6ba4c5436
        }
    }
}
