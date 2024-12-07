namespace CustomCars.Components
{
    public class BaseCar : Car
    {
        public BaseCar()
        {
            Description += "Car configuration: "; 
        }

        public override decimal GetCost()
        {
            return 10000;
        }
    }
}
