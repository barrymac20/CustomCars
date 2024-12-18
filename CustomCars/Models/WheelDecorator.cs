﻿namespace CustomCars.Models
{
    // Enumerators
    public enum WheelSize
    {
        SeventeenInch = 17,
        NineteenInch = 19,
        TwentyOneInch = 21
    }

    public enum WheelType
    {
        Steel,
        Alloy
    }

    public class WheelSizeDecorator : CarDecorator
    {
        // Auto properties
        public WheelSize WheelSize { get; set; }

        // Constructors
        public WheelSizeDecorator(Car car, WheelSize wheelSize) : base(car)
        {
            WheelSize = wheelSize;
        }

        // Methods
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

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetWheelSizeCost(WheelSize);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with {GetWheelSize(WheelSize)}\"";
        }
    }

    public class WheelTypeDecorator : CarDecorator
    {
        // Auto properties
        public WheelType WheelType { get; set; }

        // Constructors
        public WheelTypeDecorator(Car car, WheelType wheelType) : base(car)
        {
            WheelType = wheelType;
        }

        // Methods
        public static decimal GetWheelTypeCost(WheelType wheelType)
        {
            return wheelType switch
            {
                WheelType.Steel => 0,
                WheelType.Alloy => 2000,
                _ => 0
            };
        }

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetWheelTypeCost(WheelType);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} {WheelType.ToString().ToLower()} wheels,";
        }
    }
}