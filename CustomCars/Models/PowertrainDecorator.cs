namespace CustomCars.Models
{
    public enum Powertrain
    {
        Petrol,
        Diesel,
        Hybrid,
        Electric
    }
    public class PowertrainDecorator : CarDecorator
    {
        public Powertrain Powertrain { get; set; }

        public PowertrainDecorator(Car car, Powertrain powertrain) : base(car)
        {
            Powertrain = powertrain;
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetPowertrainCost(Powertrain);
        }

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

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with {Powertrain.ToString().ToLower()} powertrain,";
        }
    }
}
