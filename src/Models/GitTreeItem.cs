using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public record GitTreeItem
{
    public string? Path { get; init; } 
}