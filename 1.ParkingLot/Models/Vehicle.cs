using ParkingLot.Enums;

namespace ParkingLot.Models;

public class Vehicle
{
    public Guid Id { get; }
    public VehicleType Type { get; }
    public string VehicleNumber { get; }

    public Vehicle(VehicleType type, string vehicleNumber)
    {
        this.VehicleNumber = vehicleNumber;
        this.Type = type;
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return "Vehicle{" +
                "id=" + Id +
                ", licensePlate='" + VehicleNumber + '\'' +
                ", vehicleType=" + Type +
                '}';
    }
}