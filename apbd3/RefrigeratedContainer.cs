namespace apbd3;

public class RefrigeratedContainer : Container
{

    public string productType { get; set; }
    public double temperature { get; set; }
    
    public RefrigeratedContainer(string productType, double temperature, double height, double tareWeight, double cargoWeight,
        double depth,
        double maxPayload) : base( height, tareWeight, cargoWeight, depth, maxPayload)
    {
        this.productType = productType;
        this.temperature = temperature;
    }
    
}