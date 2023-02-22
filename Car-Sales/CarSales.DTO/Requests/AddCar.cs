using CarSales.DTO.Common;

namespace CarSales.DTO.Requests;

public class AddCar
{
    public required Guid Id { get; init; }
    public required string Manufacturer { get; init; }
    public required string Model { get; init; }
    public required string ManufactureYear { get; init; }
    public required string RegistrationNumber { get; init; }
    public required string RegistrationDate { get; init; }
    public required string OwnerName { get; init; }
    public required FuelType FuelType { get; init; } 
    public string? RegistrationCardNumber { get; init; }
}