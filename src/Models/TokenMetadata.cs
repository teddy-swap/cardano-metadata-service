using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public class TokenMetadata
{
    public string Subject { get; init; } = string.Empty;
    public JsonElement Data { get; init; }
}