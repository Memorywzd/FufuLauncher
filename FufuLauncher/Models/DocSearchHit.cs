namespace FufuLauncher.Models;

public sealed class DocSearchHit
{
    public required DocItem Item { get; init; }

    public string CategoryName { get; init; } = string.Empty;
    
    public string Preview { get; init; } = string.Empty;

    public string Title => Item.Title;

    public string Subtitle => string.IsNullOrEmpty(CategoryName)
        ? Item.File
        : $"{CategoryName} · {Item.File}";
}