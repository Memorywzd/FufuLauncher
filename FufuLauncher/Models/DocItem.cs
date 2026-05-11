using System.Text.Json.Serialization;

namespace FufuLauncher.Models;

public class DocItem
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("file")]
    public string File { get; set; } = string.Empty;

    [JsonPropertyName("author")]
    public string Author { get; set; } = string.Empty;

    [JsonIgnore]
    public string Category { get; set; } = string.Empty;
}