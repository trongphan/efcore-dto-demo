using Microsoft.EntityFrameworkCore;

namespace EFCore.Domain.PeopleManagement.Data;

public class PeopleManagementContext : DbContext
{
    public PeopleManagementContext() { }
    public PeopleManagementContext(DbContextOptions<PeopleManagementContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
