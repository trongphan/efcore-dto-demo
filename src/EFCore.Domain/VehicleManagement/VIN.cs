using EFCore.Domain.VehicleManagement.Exceptions;
using System.Text.RegularExpressions;

namespace EFCore.Domain.VehicleManagement;

public record VIN(string Value)
{
    private static Regex VinValidationRegex = new Regex("[A-HJ-NPR-Z0-9]{17}");

    public static VIN Create(string value)
    {
        if (!IsValid(value))
        {
            throw new InvalidVinException();
        }

        return new VIN(value);
    }

    public static bool IsValid(string value) => VinValidationRegex.IsMatch(value);
}
