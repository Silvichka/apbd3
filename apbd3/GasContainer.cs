namespace apbd3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double Pressure, double height, double tareWeight, double cargoWeight,
        double depth,
        double maxPayload) : base(height, tareWeight, cargoWeight, depth, maxPayload)
    {
        this.Pressure = Pressure;
    }

    public override void emptyCargo()
    {
        mass *= 0.05;
    }

    public override void loadCargo(int loadingMass)
    {
        if (loadingMass > maxPayload)
        {
            throw new Exception("Exceeded maximum payload of container");
        }
        else
        {
            sendHazardousNatifications("This cargo contain dangerous materials");
            mass = loadingMass;
        }
    }
    
    public void sendHazardousNatifications(string message)
    {
        Console.WriteLine($"{message}, No {serialNumber}");
    }
    
}