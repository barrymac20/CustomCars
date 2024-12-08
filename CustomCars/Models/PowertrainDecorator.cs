namespace CustomCars.Models
{
    // Enumerators
    public enum Powertrain
    {
        Petrol,
        Diesel,
        Hybrid,
        Electric
    }

    public class PowertrainDecorator : CarDecorator
    {
        // Auto properties
        public Powertrain Powertrain { get; set; }

        // Constructors
        public PowertrainDecorator(Car car, Powertrain powertrain) : base(car)
        {
            Powertrain = powertrain;
        }

        // Methods
        public static decimal GetPowertrainCost(Powertrain powertrain)
        {
            return powertrain switch
            {
                Powertrain.Petrol => 0,
                Powertrain.Diesel => 5000,
                Powertrain.Hybrid => 10000,
                Powertrain.Electric => 15000,
                _ => 0
            };
        }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetPowertrainCost(Powertrain);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with {Powertrain.ToString().ToLower()} powertrain,";
        }
    }
}