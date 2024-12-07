namespace CustomCars.Components
{
    public class Hatchback : Car
    {
        public Hatchback()
        {
            CarType = CarType.Hatchback;
            Description += "Hatchback";
        }

        public override decimal GetCost()
        {
            return 10000;
        }
    }

    public class Crossover : Car
    {
        public Crossover()
        {
            CarType = CarType.Crossover;
            Description += "Crossover";
        }

        public override decimal GetCost()
        {
            return 15000;
        }
    }
}
