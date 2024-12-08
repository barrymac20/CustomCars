namespace CustomCars.Models
{
    // Enumerators
    // Using enum value to define cost as each one is unique
    public enum CarType
    {
        Hatchback = 10000,
        Crossover = 15000,
        Saloon = 20000,
        Estate = 25000,
        SUV = 30000,
        MPV = 35000,
        Pickup = 40000,
        Van = 45000
    }

    public class CarTypeDecorator : CarDecorator
    {
        // Auto properties
        public CarType CarType { get; set; }

        // Constructors
        public CarTypeDecorator(Car car, CarType carType) : base(car)
        {
            CarType = carType;
        }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + (decimal)CarType;
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} {CarType}";
        }
    }
}