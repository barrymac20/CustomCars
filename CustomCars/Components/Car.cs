namespace CustomCars.Components
{
    

    public abstract class Car
    {
        // Methods
        public string Description { get; set; }

        public abstract decimal GetCost();
    }

    public abstract class CarDecorator : Car
    {
        public abstract string GetDescription();
    }
}
