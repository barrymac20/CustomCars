namespace CustomCars.Components
{
    public enum WheelSize
    {
        SeventeenInch = 17,
        NineteenInch = 19,
        TwentyOneInch = 21
    }

    public enum WheelType
    {
        Steel, Alloy
    }
    public class WheelSizeDecorator : CarDecorator

    {
        public Car Car { get; set; }

        public WheelSize WheelSize { get; set; }

        public WheelSizeDecorator(Car car, WheelSize wheelSize)
        {
            Car = car;
            WheelSize = wheelSize;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            if (WheelSize == WheelSize.NineteenInch)
                return Car.GetCost() + 400;
            else if (WheelSize == WheelSize.TwentyOneInch)
                return Car.GetCost() + 800;
            else
                return Car.GetCost();
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with {(int)WheelSize}\"";
        }
    }

    public class WheelTypeDecorator : CarDecorator

    {
        public Car Car { get; set; }

        public WheelType WheelType { get; set; }

        public WheelTypeDecorator(Car car, WheelType wheelType)
        {
            Car = car;
            WheelType = wheelType;
            Description = GetDescription();
        }

        public override decimal GetCost()
        {
            if (WheelType == WheelType.Alloy)
                return Car.GetCost() + 1000;
            else
                return Car.GetCost();
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with {WheelType.ToString().ToLower()} wheels\"";
        }
    }
}
