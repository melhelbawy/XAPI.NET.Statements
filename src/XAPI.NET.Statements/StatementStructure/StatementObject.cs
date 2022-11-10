namespace XAPI.NET.Statements.StatementStructure;

public record StatementObject
{
    public string Id { get; set; }
    public Definition Definition { get; set; }
    public string ObjectType { get; set; }
}
public record Definition
{
    public ObjectItem Name { get; set; }

    public ObjectItem Description { get; set; }
    public string Type { get; set; }
    public Definition(ObjectItem name, ObjectItem description, string type)
    {
        Name = name;
        Description = description;
        Type = type;
    }

}

public record ObjectItem(string Language, string Term);