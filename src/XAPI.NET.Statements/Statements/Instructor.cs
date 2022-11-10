﻿namespace XAPI.NET.Statements.Statements;
public record Instructor
{
    public string Name { get; init; }
    public string Mbox { get; init; }

    public Instructor(string name, string email)
    {
        Name = name;
        Mbox = $"mailto: {email}";
    }
}
