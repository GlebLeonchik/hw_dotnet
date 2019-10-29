using System;

public class AutomobileAudiBase
{
    internal const int MaxSpeed = 260;

    protected string CarModel = "Audi";
    public string Color = "Red";
    private string VIN = "0000 - 0000 - 0000 - 0000";
    public string CarBody = "Sedan";
    protected internal string SteeringWheelSide = "Left";
    private protected int Speedometer = 0;
    public int NumOfDoors = 4;

    public string GetVIN(string txt)
    {
        VIN = txt;
        return VIN;
    }

    public int GetSpeed(int num)
    {
        Speedometer = num;
        return Speedometer;
    }

        public void Info()
    {
        Console.WriteLine("Max Speed - "+MaxSpeed);
        Console.WriteLine("Car Model - "+CarModel);
        Console.WriteLine("Color - "+Color);
        Console.WriteLine("VIN : "+VIN);
        Console.WriteLine("Car body - "+CarBody);
        Console.WriteLine("Side of Steering Wheel - "+SteeringWheelSide);
        Console.WriteLine("Speedometer - "+Speedometer);
        Console.WriteLine("Number of Doors - "+NumOfDoors);
        Console.WriteLine();
    }
}

internal class AutomobileSeller : AutomobileAudiBase
{
    public void ChangesFromSeller()
    {
        Info();
        Console.WriteLine();
    }
}

internal class AutomobileBuyer : AutomobileSeller
{
    public void ChangedFromBuyer()
    {
        Info();
        Console.WriteLine();
    }
}

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomobileAudiBase AutoA = new AutomobileAudiBase();
            Console.WriteLine("Base Info:");
            AutoA.Info();

            AutomobileSeller AutoSell = new AutomobileSeller();
            Console.WriteLine("Seller Info:");
            AutoSell.Info();

            AutomobileBuyer AutoBuy = new AutomobileBuyer();
            Console.WriteLine("Buyer Car:");
            AutoBuy.GetVIN("2222 - 2222 - 2222 - 2222");
            AutoBuy.Color = "Pink";
            AutoBuy.GetSpeed(50000);
            AutoBuy.CarBody = "Truck";
            AutoBuy.NumOfDoors = 3;
            AutoBuy.SteeringWheelSide = "None";
            AutoBuy.Info();
            Console.ReadKey();
        }
    }
}
