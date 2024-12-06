namespace CustomCars.Components
{
    public class Hatchback : Car
    {
        public Hatchback()
        {
            CarType = CarType.Hatchback;
            Description += "Hatchback";
            Cost = 10000;
        }
    }

    public class Crossover : Car
    {
        public Crossover()
        {
            CarType = CarType.Crossover;
            Description += "Crossover";
            Cost = 15000;
        }
}
