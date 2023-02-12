using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public record TokenMetadata
{
    public string Subject { get; init; } = string.Empty;
    public JsonElement Data { get; set; }
}