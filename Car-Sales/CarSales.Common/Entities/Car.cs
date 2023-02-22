namespace CarSales.Common.Entities;

public class Car
{
    public required string Manufacturer { get; init; }
    public required string Model { get; init; }
    public required string ManufactureYear { get; init; }
    public required string RegistrationNumber { get; init; }
    public required string RegistrationDate { get; init; }
    public required string OwnerName { get; init; }
    public required string OwnerMobile { get; init; }
    public required string FuelType { get; init; }
    public required Guid Id { get; init; }
    public string? RegistrationCardNumber { get; init; }
}