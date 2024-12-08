namespace CustomCars.Models
{
    public abstract class Car
    {
        // Properties
        public string Description { get; set; }

        // Methods
        public abstract string GetDescription();
        public abstract decimal GetCost();
    }

    public abstract class CarDecorator : Car
    {
        public Car Car { get; set; }

        public CarDecorator(Car car)
        {
            Car = car;
            Description = GetDescription();
        }

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
