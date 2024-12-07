namespace CustomCars.Components
{
    public enum WheelSize
    {
        SeventeenInch = 0,
        NineteenInch = 400,
        TwentyOneInch = 800
    }

    public enum WheelType
    {
        Steel = 0,
        Alloy = 2000
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
            return Car.GetCost() + (Decimal)WheelSize;
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
            return Car.GetCost() + (Decimal)WheelType;

        }

        public override string GetDescription()
        {
            return $"{Car.Description} {WheelType.ToString().ToLower()} wheels";
        }
    }
}
