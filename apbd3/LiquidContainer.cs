using System.Security.AccessControl;

namespace apbd3;

public class LiquidContainer : Container, IHazardNotifier
{
    
    public bool isHazardous { get; set; }

    public LiquidContainer(bool isHazardous, double height, double tareWeight, double cargoWeight, double depth,
        double maxPayload) : base(height, tareWeight, cargoWeight, depth, maxPayload)
    {
        this.isHazardous = isHazardous;
    }

    public override void loadCargo(int loadingMass)
    {
        maxPayload = isHazardous ? 0.5 * maxPayload : 0.9 * maxPayload;
        if (loadingMass > maxPayload)
        {
            sendHazardousNatifications($"Hazard loading {serialNumber}");
        }
        else
        {
            mass = loadingMass;
        }
    }


    public void sendHazardousNatifications(string message)
    {
        Console.WriteLine(message);
    }
    
}