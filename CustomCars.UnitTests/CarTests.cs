using CustomCars.Models;
namespace CustomCars.UnitTests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        // Test to check base car cost 10000
        public void BaseCarDefaultCostShouldBe10000()
        {
            // Arrange
            Car baseCar = new BaseCar();

            // Act
            var cost = baseCar.GetCost();

            // Assert
            Assert.That(cost, Is.EqualTo(10000));
        }

        [Test]
        // Test to check base car default description
        public void BaseCar_DefaultDescription_ShouldMatch()
        {
            // Arrange
            var baseCar = new BaseCar();

            // Act
            var description = baseCar.GetDescription();

            // Assert
            Assert.That(description, Is.EqualTo("Car configuration:"));
        }
    }
}