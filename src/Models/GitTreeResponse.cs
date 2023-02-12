using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public record GitTreeResponse
{
    public GitTreeItem[]? Tree { get; init; }
}