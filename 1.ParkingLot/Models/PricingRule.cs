using ParkingLot.Enums;

public class PricingRule
{
    public Guid Id { get; }
    public VehicleType VehicleType { get; set; }
    public double RatePerHour { get; private set; }
    public double FlatRate { get; private set; }

    public PricingRule(VehicleType vehicleType, double ratePerHour, double flatRate)
    {
        Id = Guid.NewGuid();
        VehicleType = vehicleType;
        RatePerHour = ratePerHour;
        FlatRate = flatRate;
    }

    public void UpdateRates(double ratePerHour, double flatRate)
    {
        RatePerHour = ratePerHour;
        FlatRate = flatRate;
    }

    public void UpdateFlatRate(double flatRate)
    {
        FlatRate = flatRate;
    }

    public void UpdateRatePerHour(double ratePerHour)
    {
        RatePerHour = ratePerHour;
    }

    public override string ToString()
    {
        return "PricingRule{" +
                "id=" + Id +
                ", vehicleType=" + VehicleType +
                ", ratePerHour=" + RatePerHour +
                ", flatRate=" + FlatRate +
                '}';
    }

}