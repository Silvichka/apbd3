
using apbd3;

public class Program{

    public static void Main(string[] args)
    {
        ContainerShip ship = new ContainerShip("Titanic",10, 100, 1000);

        LiquidContainer lc = new LiquidContainer(false, 2, 0, 0, 2, 100);
        lc.loadCargo(67);
        lc.printContainerInfo();
        ship.loadContainer(lc);
        ship.printInfo();

        GasContainer gc = new GasContainer(100, 2, 0, 0, 2, 100);
        gc.loadCargo(80);
        gc.printContainerInfo();
        ship.loadContainer(gc);
        ship.printInfo();

        RefrigeratedContainer rc = new RefrigeratedContainer("bananas", 13.3, 2, 0, 0, 2, 100);
        rc.loadCargo(95);
        rc.printContainerInfo();
        ship.loadContainer(rc);
        ship.printInfo();
        
// ---------------------------------------------------------------------------------------------------------------------------------------------------------------
        RefrigeratedContainer rc2 = new RefrigeratedContainer("bananas", 13.3, 2, 0, 0, 2, 100);
        GasContainer gc2 = new GasContainer(100, 2, 0, 0, 2, 100);
        rc2.loadCargo(95);
        gc2.loadCargo(80);
        List<Container> containers = new List<Container>();
        containers.Add(rc2);
        containers.Add(gc2);
        
        ContainerShip ship2 = new ContainerShip("GreenDay",10, 100, 1000);
        ship2.loadContainers(containers);
        ship2.printInfo();
        ship2.removeContainer(gc2);
        ship2.printInfo();
// -----------------------------------------------------------------------------------------------------------------------------------------------------------------    
        ship.transferContainers(gc, ship2);
        ship.printInfo();
        ship2.printInfo();
// -----------------------------------------------------------------------------------------------------------------------------------------------------------------    

        ship.replaceContainers(lc, gc);
        ship.printInfo();
    }
    
}