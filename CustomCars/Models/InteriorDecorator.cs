namespace CustomCars.Models
{
    //Enumerators
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
        // Auto properties
        public InteriorColour InteriorColour { get; set; }

        // Constructors
        public InteriorColourDecorator(Car car, InteriorColour interiorColour) : base(car)
        {
            InteriorColour = interiorColour;
        }

        // Methods
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

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetInteriorColourCost(InteriorColour);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} with {InteriorColour.ToString().ToLower()}";
        }
    }

    public class InteriorMaterialDecorator : CarDecorator
    {
        // Auto properties
        public InteriorMaterial InteriorMaterial { get; set; }

        // Constructors
        public InteriorMaterialDecorator(Car car, InteriorMaterial interiorMaterial) : base(car)
        {
            InteriorMaterial = interiorMaterial;
        }

        // Methods
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

        // Override methods
        public override decimal GetCost()
        {
            return Car.GetCost() + GetInteriorMaterialCost(InteriorMaterial);
        }

        public override string GetDescription()
        {
            return $"{Car.GetDescription()} {InteriorMaterial.ToString().ToLower()} interior";
        }
    }
}