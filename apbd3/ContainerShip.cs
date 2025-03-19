namespace apbd3;

public class ContainerShip
{

    public List<Container> containers { get; set; }
    public string name { get;  }
    public int maxSpeed { get; set; }
    public int maxNumOfContainers { get; set; }
    public double maxWeight { get; set; }

    public ContainerShip(string name, int maxSpeed, int maxNumOfContainers, double maxWeight)
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
        this.maxNumOfContainers = maxNumOfContainers;
        this.maxWeight = maxWeight;
        containers = new List<Container>();
    }
    
    public void loadContainer(Container container)
    {
        if (containers.Count >= maxNumOfContainers)
            throw new Exception("Max container limit reached!");
        
        double totalWeight = containers.Sum(c => c.mass) + container.mass;
        if (totalWeight > maxWeight)
            throw new Exception("Ship overloaded!");

        containers.Add(container);
    }
    
    public void loadContainers(List<Container> loadContainers)
    {
        if (containers.Count >= maxNumOfContainers)
            throw new Exception("Max container limit reached!");

        foreach (var load in loadContainers)
        {
            double totalWeight = containers.Sum(c => c.mass) + load.mass;
            if (totalWeight > maxWeight)
                throw new Exception("Ship overloaded!");

            containers.Add(load);
        }
        
    }

    public void removeContainer(Container container)
    {
        if (containers.Count != 0)
        {
            containers.Remove(container);
        }
        else
        {
            throw new Exception("Ship doesn't have any containers!");
        }
        
    }
    
    public void transferContainers(Container container, ContainerShip targetShip)
    {
        if (!containers.Contains(container))
            throw new Exception("Container not found on this ship!");

        targetShip.loadContainer(container);
        removeContainer(container);
    }
    
    public void replaceContainers(Container container, Container targetContainer)
    {
        if (!containers.Contains(container))
            throw new Exception("Container not found on this ship!");
        
        removeContainer(container);
        loadContainer(targetContainer);
    }

    public void printInfo()
    {
        Console.WriteLine($"Ship's name: {name}, max containers: {maxNumOfContainers}, max weight: {maxWeight}");
        Console.WriteLine("------------------------------------------------");
        foreach (var container in containers)
        {
            
            container.printContainerInfo();
        }
        Console.WriteLine("------------------------------------------------");
    }
    
}