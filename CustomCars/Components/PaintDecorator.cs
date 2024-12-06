namespace CustomCars.Components
{
    public enum PaintColour
    {
        Red, White, Blue, Black
    }

    public enum PaintType
    {
        Standard, Metallic
    }

    public abstract class PaintTypeDecorator : CarDecorator
    {
        public PaintColour PaintColour { get; set; }
        public PaintType PaintType { get; set; } = PaintType.Standard;

        public PaintTypeDecorator(Car car, PaintType paintType)
        {
            PaintType = paintType;
            Description = car.Description;
            Cost = GetPaintTypeCost();
        }

        public override string Description { get; }

        public override decimal Cost { get; }

        private decimal GetPaintTypeCost()
        {
            if (PaintType == PaintType.Metallic)
                return 1500;
            else if (PaintType == PaintType.Standard)
                return 1200;
            return 1000;
        }
    }

    public abstract class PaintColourDecorator : CarDecorator
    {
        public PaintColour PaintColour { get; set; }

        public PaintColourDecorator(Car car, PaintColour paintColour)
        {
            Description = car.Description;
            Cost = GetPaintColourCost();
        }

        public override string Description { get; }

        public override decimal Cost { get; }

        private decimal GetPaintColourCost()
        {
            if (PaintColour == PaintColour.Black)
                return 200;
            else
                return 0;
        }
    }
}


