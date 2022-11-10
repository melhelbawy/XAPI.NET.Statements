using System.Text.Json.Serialization;

namespace XAPI.NET.Statements.Statements;
public record Verb
{
    [JsonPropertyName("id")]
    public string Id { get; init; }
    public Display Display { get; init; }
    public Verb(string id, Display display)
    {
        Id = id;
        Display = display;
    }
};
public record Display
{
    [JsonPropertyName("en-US")]
    public string Value { get; init; }

    public Display(string value)
    {
        Value = value;
    }
}