namespace CustomCars.Models
{
    public enum InteriorColour
    {
        Black,
        White,
        Cream,
        Red
    }

    public enum InteriorMaterial
    {
        Cloth,
        Vinyl,
        Leather,
        Suede
    }

    public class InteriorColourDecorator : CarDecorator
    {
        public InteriorColour InteriorColour { get; set; }

        public InteriorColourDecorator(Car car, InteriorColour interiorColour) : base(car)
        {
            InteriorColour = interiorColour;
            Description = GetDescription();
        }

        public static decimal GetInteriorColourCost(InteriorColour interiorColour)
        {
            return interiorColour switch
            {
                InteriorColour.Black => 0,
                InteriorColour.White => 1000,
                InteriorColour.Cream => 2000,
                InteriorColour.Red => 3000,
                _ => 0
            };
        }

        public override decimal GetCost()
        {
            return Car.GetCost() + GetInteriorColourCost(InteriorColour);
        }

        public override string GetDescription()
        {
            return $"{Car.Description} with {InteriorColour.ToString().ToLower()}";
        }
    }

    public class InteriorMaterialDecorator : CarDecorator
    {
        public InteriorMaterial InteriorMaterial { get; set; }

        public InteriorMaterialDecorator(Car car, InteriorMaterial interiorMaterial) : base(car)
        {
            InteriorMaterial = interiorMaterial;
            Description = GetDescription();
        }

        public static decimal GetInteriorMaterialCost(InteriorMaterial interiorMaterial)
        {
            return interiorMaterial switch
            {
                InteriorMaterial.Cloth => 0,
                InteriorMaterial.Vinyl => 2000,
                InteriorMaterial.Leather => 5000,
                InteriorMaterial.Suede => 8000,
                _ => 0
            };
        }
        public override decimal GetCost()
        {
            return Car.GetCost() + GetInteriorMaterialCost(InteriorMaterial);
        }

        public override string GetDescription()
        {
            return $"{Car.Description} {InteriorMaterial.ToString().ToLower()} interior";
        }
    }


}


