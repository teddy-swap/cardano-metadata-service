namespace TeddySwapCardanoMetadataService.Models;

public record SyncState
{
    public string Sha { get; init; } = string.Empty;
    public DateTime Date { get; init; }
}