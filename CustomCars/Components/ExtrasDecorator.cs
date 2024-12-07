namespace CustomCars.Components
{
    public class HeatedSeatsDecorator: CarDecorator
    {
        public Car Car { get; set; }

        public HeatedSeatsDecorator(Car car)
        {
            Car = car;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + 2500;
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with heated seats";
        }
    }

    public class TouchScreenDecorator : CarDecorator
    {
        public Car Car { get; set; }

        public TouchScreenDecorator(Car car)
        {
            Car = car;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + 1500;
        }

        public override string GetDescription()
        {
            return $"{Car.Description}, touch screen controls";
        }
    }
}
