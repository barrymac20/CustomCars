namespace CustomCars.Models
{
    public class HeatedSeatsDecorator : CarDecorator
    {
        // Auto properties
        public HeatedSeatsDecorator(Car car) : base(car) { }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + 2500;
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with heated seats";
        }
    }

    public class TouchScreenDecorator : CarDecorator
    {
        // Auto properties
        public TouchScreenDecorator(Car car) : base(car) { }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + 1500;
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()}, with touch screen controls.";
        }
    }
}