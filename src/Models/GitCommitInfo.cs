using System.Text.Json;

namespace TeddySwapCardanoMetadataService.Models;

public record GitCommitInfo
{
    public GitCommitAuthor? Author { get; init; } 
}