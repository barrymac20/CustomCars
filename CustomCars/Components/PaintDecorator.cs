namespace CustomCars.Components
{
    public enum PaintColour
    {
        Red, White, Blue, Black
    }

    public enum PaintFinish
    {
        Matte, Metallic
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
            if (PaintColour == PaintColour.Black)
                return Car.GetCost() + 200;
            else
                return Car.GetCost();
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
            if (PaintFinish == PaintFinish.Metallic)
                return Car.GetCost() + 1500;
            else if (PaintFinish == PaintFinish.Matte)
                return Car.GetCost();
            return Car.GetCost();
        }

        public override string GetDescription()
        {
            return $"{Car.Description} {PaintFinish.ToString().ToLower()} paint";
        }
    }


}


