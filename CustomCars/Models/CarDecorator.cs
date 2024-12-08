namespace CustomCars.Models
{
    public abstract class CarDecorator : Car
    {
        public Car Car { get; set; }

        public CarDecorator(Car car)
        {
            Car = car;
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
