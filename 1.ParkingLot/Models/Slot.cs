using ParkingLot.Enums;

namespace ParkingLot.Models;

public class Slot
{
    public Guid Id { get; }
    public VehicleType SlotType { get; private set; }
    public bool IsAvailable { get; set; }
    public int FloorNumber { get; set; }

    public Slot(VehicleType type, int floorNumber)
    {
        Id = Guid.NewGuid();
        SlotType = type;
        IsAvailable = true;
        FloorNumber = floorNumber;
    }

    public override string ToString()
    {
        return "ParkingSlot{" +
                "id=" + Id +
                ", slotType=" + SlotType +
                ", isAvailable=" + IsAvailable +
                ", floorNumber=" + FloorNumber +
                '}';
    }
}