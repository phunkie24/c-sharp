
using System;
using System.Xml.Linq;
using System.Linq;

public static class LinqToXmlExample
{
    public static void Run()
    {
        Console.WriteLine("-- LINQ to XML Example --");
        var xml = new XElement("People",
            new XElement("Person", new XAttribute("Name","Tom"), new XAttribute("Age",40)),
            new XElement("Person", new XAttribute("Name","Mary"), new XAttribute("Age",30))
        );

        var q = from p in xml.Elements("Person")
                where (int)p.Attribute("Age") > 35
                select (string)p.Attribute("Name");

        foreach(var n in q) Console.WriteLine(n);
        Console.WriteLine();
    }
}
