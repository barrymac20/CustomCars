namespace CustomCars.Models
{
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
        Convertible = 45000
    }

    public class CarTypeDecorator : CarDecorator
    {
        public CarType CarType { get; set; }
        public CarTypeDecorator(Car car, CarType carType) : base(car)
        {
            CarType = carType;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + (decimal)CarType;
        }

        public override string GetDescription()
        {
            return $"{Car.Description} {CarType}";
        }
    }
}
