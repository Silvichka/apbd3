namespace apbd3;

public class Container
{
    private static int number = 1;
    public string serialNumber { get; }
    public double mass { get; set; }
    public double height { get; set; }
    public double tareWeight { get; set; }
    public double cargoWeight { get; set; }
    public double depth { get; set; }
    public double maxPayload { get; set; }

    public Container(double height, double tareWeight, double cargoWeight, double depth,
        double maxPayload)
    {
        serialNumber = $"KON-{GetType().Name[0]}-{number++}";
        this.mass = tareWeight;
        this.height = height;
        this.tareWeight = tareWeight;
        this.cargoWeight = cargoWeight;
        this.depth = depth;
        this.maxPayload = maxPayload;
    }

    public virtual void emptyCargo()
    {
        cargoWeight = 0;
    }

    public virtual void loadCargo(int loadMass)
    {
        if (mass > maxPayload)
        {
            throw new Exception("Cannot load this container with this mass");
        }
        else
        {
            cargoWeight += loadMass;
            mass += loadMass + tareWeight;
        }
    }

    public void printContainerInfo()
    {
        Console.WriteLine($"###########Container's serial number: {serialNumber}####################"+
                          $"\nmass: {mass}," +
                          $"\nheight: {height}," +
                          $"\ntare weight: {tareWeight}," +
                          $"\ncargo weight: {cargoWeight}," +
                          $"\ndepth: {depth}," +
                          $"\nmax payload: {maxPayload}" +
                          $"\n########################################################");
    }
}