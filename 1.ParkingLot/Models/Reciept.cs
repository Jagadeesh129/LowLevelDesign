public class Reciept
{
    public Guid Id { get; }
    public Guid TicketId { get; }
    public DateTime ExitTime { get; private set; }
    public double TotalFee { get; private set; }

    public Reciept(Guid ticketId, double totalFee)
    {
        Id = Guid.NewGuid();
        TicketId = ticketId;
        TotalFee = totalFee;
        ExitTime = DateTime.Now;
    }

    public override String ToString() {
        return "Receipt{" +
                "id=" + Id +
                ", ticketId=" + TicketId +
                ", exitTime=" + ExitTime +
                ", totalFee=" + TotalFee +
                '}';
    }
}