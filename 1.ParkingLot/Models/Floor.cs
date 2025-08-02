using ParkingLot.Enums;

namespace ParkingLot.Models;

public class Floor
{
    public Guid Id { get; }
    public int FloorNumber { get; }
    public List<Slot> Slots { get; private set; }

    public Floor(int floorNumber)
    {
        Id = Guid.NewGuid();
        FloorNumber = floorNumber;
        Slots = [];
    }

    public void AddSlot(Slot slot)
    {
        Slots.Add(slot);
    }

    public List<Slot> getAvailableSlots(VehicleType vehicleType)
    {
        List<Slot> availableSlots = new List<Slot>();
        foreach (Slot slot in Slots)
        {
            if (slot.SlotType == vehicleType)
            {
                availableSlots.Add(slot);
            }
        }
        return availableSlots;
    }

    public override string ToString()
    {
        return "Floor{" +
                "id=" + Id +
                ", floorNumber=" + FloorNumber +
                ", totalSlots=" + Slots.Count +
                '}';
    }
}