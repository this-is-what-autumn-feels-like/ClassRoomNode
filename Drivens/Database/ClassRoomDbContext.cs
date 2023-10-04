using Application.Domain.Entities;
using Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Database;

public class ClassRoomDbContext : DbContext
{
    public required DbSet<Organization> Organizations { get; init; }
    public required DbSet<OrgMember> OrgMembers { get; init; }
    public required DbSet<ClassRoom> ClassRooms { get; init; }
    public required DbSet<ClassMember> ClassMembers { get; init; }
    
    public ClassRoomDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntityConfiguration<,>).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}