namespace CustomCars.Models
{
    public class BaseCar : Car
    {
        public BaseCar()
        {
            Description = GetDescription();
        }
        public override string GetDescription()
        {
            return $"Car configuration: ";
        }

        public override decimal GetCost()
        {
            return 10000;
        }
    }
}
