namespace TeddySwapCardanoMetadataService.Models;

public record SyncState
{
    public string Sha { get; init; } = string.Empty;
    public string Date { get; init; } = string.Empty;
}