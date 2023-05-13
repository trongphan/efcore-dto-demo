using Microsoft.EntityFrameworkCore;

namespace EFCore.Domain.Migrations;

public class MigrationContext : DbContext
{
    public MigrationContext() { }
    public MigrationContext(DbContextOptions<MigrationContext> options)
        : base(options) { }
}