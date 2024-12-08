namespace CustomCars.Models
{
    public class BaseCar : Car
    {
        // Constructors
        public BaseCar() { }

        // Override methods
        public override string GetDescription()
        {
            return Description;
        }

        public override decimal GetCost()
        {
            return 10000;
        }
    }
}