// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string st = "ab\\c";

//literal string

string s2 = """ John said: "Let's learn c#" """;
Console.WriteLine(s2);

string s3 = """
    abc
    dec
    {
        "level" : "information"
    }
    """;

string level = "Information";

string s4 = $$"""
    abc
    dec
    {
        "level" : {{level}}
    }
    """;

Console.WriteLine(s4);