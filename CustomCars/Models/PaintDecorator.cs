namespace CustomCars.Models
{
    // Enumerators
    public enum PaintColour
    {
        Red,
        White,
        Blue,
        Black
    }

    public enum PaintFinish
    {
        Matte,
        Metallic
    }

    public class PaintColourDecorator : CarDecorator
    {
        // Auto properties
        public PaintColour PaintColour { get; set; }

        // Constructors
        public PaintColourDecorator(Car car, PaintColour paintColour) : base(car)
        {
            PaintColour = paintColour;
        }

        // Methods
        public static decimal GetPaintColourCost(PaintColour paintColour)
        {
            return paintColour switch
            {
                PaintColour.Red => 0,
                PaintColour.White => 0,
                PaintColour.Blue => 0,
                PaintColour.Black => 500,
                _ => 0
            };
        }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetPaintColourCost(PaintColour);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with {PaintColour.ToString().ToLower()}";
        }
    }

    public class PaintTypeDecorator : CarDecorator
    {
        // Auto properties
        public PaintFinish PaintFinish { get; set; }

        // Constructors
        public PaintTypeDecorator(Car car, PaintFinish paintFinish) : base(car)
        {
            PaintFinish = paintFinish;
        }

        // Methods
        public static decimal GetPaintFinishCost(PaintFinish paintFinish)
        {
            return paintFinish switch
            {
                PaintFinish.Matte => 0,
                PaintFinish.Metallic => 2000,
                _ => 0
            };
        }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetPaintFinishCost(PaintFinish);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} {PaintFinish.ToString().ToLower()} paint,";
        }
    }
}