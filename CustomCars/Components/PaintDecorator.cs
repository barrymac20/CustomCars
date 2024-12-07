namespace CustomCars.Components
{
    public enum PaintColour
    {
        Red = 0,
        White = 0,
        Blue = 0,
        Black = 500
    }

    public enum PaintFinish
    {
        Matte = 0, 
        Metallic = 2000
    }

    public class PaintColourDecorator : CarDecorator
    {
        public Car Car { get; set; }

        public PaintColour PaintColour { get; set; }

        public PaintColourDecorator(Car car, PaintColour paintColour)
        {
            Car = car;
            PaintColour = paintColour;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + (Decimal)PaintColour;
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with {PaintColour.ToString().ToLower()}";
        }
    }

    public class PaintTypeDecorator : CarDecorator
    {
        public Car Car { get; set; }
        public PaintFinish PaintFinish { get; set; }

        public PaintTypeDecorator(Car car, PaintFinish paintFinish)
        {
            Car = car;
            PaintFinish = paintFinish;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + (Decimal)PaintFinish;
        }

        public override string GetDescription()
        {
            return $"{Car.Description} {PaintFinish.ToString().ToLower()} paint";
        }
    }


}


