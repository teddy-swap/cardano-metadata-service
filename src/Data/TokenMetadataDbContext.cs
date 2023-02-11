using Microsoft.EntityFrameworkCore;
using TeddySwapCardanoMetadataService.Models;

namespace TeddySwapCardanoMetadataService.Data;

public class TokenMetadataDbContext : DbContext
{
    public DbSet<TokenMetadata> TokenMetadata => Set<TokenMetadata>();
    public DbSet<SyncState> SyncState => Set<SyncState>();
    public TokenMetadataDbContext(DbContextOptions<TokenMetadataDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TokenMetadata>().HasKey(tmd => tmd.Subject);
        modelBuilder.Entity<SyncState>().HasKey(ss => ss.Sha);
    }
}