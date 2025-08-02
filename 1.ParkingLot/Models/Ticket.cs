public class Ticket
{
    public Guid Id { get; }
    public Guid VehicleId { get; }
    public Guid SlotId { get; }
    public DateTime EntryTime { get; }
    public bool IsActive { get; private set; }

    public Ticket(Guid vehicleId, Guid slotId)
    {
        this.VehicleId = vehicleId;
        this.SlotId = slotId;
        EntryTime = DateTime.Now;
        IsActive = true;
    }

    public void deActivateTicket()
    {
        IsActive = false;
    }

    public override string ToString()
    {
        return "Ticket{" +
                "id=" + Id +
                ", vehicleId=" + VehicleId +
                ", slotId=" + SlotId +
                ", entryTime=" + EntryTime +
                ", isActive=" + IsActive +
                '}';
    }
}