namespace CustomCars.Models
{
    public class BaseCar : Car
    {
        public BaseCar() { }

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
