namespace CustomCars.Components
{
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

        public PaintColour PaintColour { get; set; }

        public PaintColourDecorator(Car car, PaintColour paintColour) : base(car)
        {
            PaintColour = paintColour;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetPaintColourCost(PaintColour);
        }

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

        public override string GetDescription()
        {
            return $"{Car.Description} with {PaintColour.ToString().ToLower()}";
        }
    }

    public class PaintTypeDecorator : CarDecorator
    {
        public PaintFinish PaintFinish { get; set; }

        public PaintTypeDecorator(Car car, PaintFinish paintFinish) : base(car)
        {
            PaintFinish = paintFinish;
            Description = GetDescription();
        }

        public static decimal GetPaintFinishCost(PaintFinish paintFinish)
        {
            return paintFinish switch
            {
                PaintFinish.Matte => 0,
                PaintFinish.Metallic => 2000,
                _ => 0
            };
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetPaintFinishCost(PaintFinish);
        }

        public override string GetDescription()
        {
            return $"{Car.Description} {PaintFinish.ToString().ToLower()} paint";
        }
    }


}


