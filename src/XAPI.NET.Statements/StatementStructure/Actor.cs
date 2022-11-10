namespace XAPI.NET.Statements.StatementStructure;
public record Actor
{
    public string Mbox { get; init; }
    public string Name { get; init; }
    public string objectType { get; private set; }

    public Actor(string email, long name)
    {
        Mbox = $"mailto: {email}";
        Name = name.ToString();
    }
};
