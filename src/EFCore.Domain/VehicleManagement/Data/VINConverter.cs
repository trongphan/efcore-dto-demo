using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Domain.VehicleManagement.Data;

public class VINConverter : ValueConverter<VIN, string>
{
    public VINConverter() : base(v => v.Value, v => VIN.Create(v)) {}
}
