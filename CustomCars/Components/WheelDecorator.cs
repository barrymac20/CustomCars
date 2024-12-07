namespace CustomCars.Components
{
    public enum WheelSize
    {
        SeventeenInch,
        NineteenInch,
        TwentyOneInch
    }

    public enum WheelType
    {
        Steel,
        Alloy
    }
    public class WheelSizeDecorator : CarDecorator
    {
        public WheelSize WheelSize { get; set; }

        public WheelSizeDecorator(Car car, WheelSize wheelSize) : base(car)
        {
            WheelSize = wheelSize;
        }

        public static decimal GetWheelSizeCost(WheelSize wheelSize)
        {
            return wheelSize switch
            {
                WheelSize.SeventeenInch => 0,
                WheelSize.NineteenInch => 400,
                WheelSize.TwentyOneInch => 800,
                _ => 0
            };
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetWheelSizeCost(WheelSize);
        }

        public int GetWheelSize(WheelSize wheelSize)
        {
            int size;
            switch (wheelSize)
            {
                case WheelSize.SeventeenInch:
                    size = 17;
                    break;
                case WheelSize.NineteenInch:
                    size = 19;
                    break;
                case WheelSize.TwentyOneInch:
                    size = 21;
                    break;
                default:
                    size = 17;
                    break;
            }
            return size;
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with {GetWheelSize(WheelSize)}\"";
        }
    }

    public class WheelTypeDecorator : CarDecorator
    {
        public WheelType WheelType { get; set; }

        public WheelTypeDecorator(Car car, WheelType wheelType): base(car)
        {
            WheelType = wheelType;
        }

        public static decimal GetWheelTypeCost(WheelType wheelType)
        {
            return wheelType switch
            {
                WheelType.Steel => 0,
                WheelType.Alloy => 2000,
                _ => 0
            };
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetWheelTypeCost(WheelType);

        }

        public override string GetDescription()
        {
            return $"{Car.Description} {WheelType.ToString().ToLower()} wheels";
        }
    }
}
