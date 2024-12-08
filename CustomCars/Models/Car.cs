namespace CustomCars.Models
{
    public abstract class Car
    {
        // Auto properties
        public string Description { get; set; } = "Car configuration:";

        // Methods
        public abstract string GetDescription();
        public abstract decimal GetCost();
    }
}