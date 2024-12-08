namespace CustomCars.Models
{
    public abstract class CarDecorator : Car
    {
        // Auto properties
        public Car Car { get; set; }

        // Constructors
        public CarDecorator(Car car)
        {
            Car = car;
        }

        // Override methods
        public override string GetDescription()
        {
            return Car.GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost();
        }
    }
}