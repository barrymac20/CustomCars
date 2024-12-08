namespace CustomCars.Models
{
    public class HeatedSeatsDecorator : CarDecorator
    {
        public HeatedSeatsDecorator(Car car) : base(car) { }

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
        public TouchScreenDecorator(Car car) : base(car) { }

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
