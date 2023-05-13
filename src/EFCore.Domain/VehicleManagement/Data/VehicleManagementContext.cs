using Microsoft.EntityFrameworkCore;

namespace EFCore.Domain.VehicleManagement.Data;

public class VehicleManagementContext : DbContext
{
    public VehicleManagementContext() { }
    public VehicleManagementContext(DbContextOptions<VehicleManagementContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
