using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public record GitCommitAuthor
{
    public string? Name { get; init; } 
    public string? Email { get; init; } 
    public DateTime? Date { get; init; } 
}