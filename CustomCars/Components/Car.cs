namespace CustomCars.Components
{
    public enum CarType
    {
        Hatchback,
        Crossover,
        Saloon,
        Convertible,
        SUV,
        Pickup,
        MPV,
        Estate
    }

    public abstract class Car
    {
        // Methods
        public CarType CarType { get; set; }
        public string Description { get; set; } = "Current configuration: ";

        public abstract decimal GetCost();
    }

    public abstract class CarDecorator : Car
    {
        public abstract string GetDescription();
    }
}
