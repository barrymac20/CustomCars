using CustomCars.Models;
namespace CustomCars.UnitTests
{
    public class DecoratorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // Test to check red paint adds zero to total cost
        public void PaintColourDecorator_WithRed_ShouldAdd_0_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            var paintColourDecorator = new PaintColourDecorator(baseCar, PaintColour.Red);

            // Act
            var cost = paintColourDecorator.GetCost();

            // Assert
            Assert.That(cost, Is.EqualTo(10000)); // 10,000 base + 0 for red paint
        }

        [Test]
        // Test to check red paint adds 500 to total cost
        public void PaintColourDecorator_WithBlack_ShouldAdd_500_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            var paintColourDecorator = new PaintColourDecorator(baseCar, PaintColour.Black);

            // Act
            var cost = paintColourDecorator.GetCost();

            // Assert
            Assert.That(cost, Is.EqualTo(10500)); // 10,000 base + 500 for black paint
        }

        [Test]
        // Test to check metallic paint adds 2000 to total cost
        public void PaintTypeDecorator_Metallic_ShouldAdd_2000_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            var paintFinishDecorator = new PaintFinishDecorator(baseCar, PaintFinish.Metallic);

            // Act
            var cost = paintFinishDecorator.GetCost();

            // Assert
            Assert.That(cost, Is.EqualTo(12000)); // 10,000 base + 2000 for metallic
        }

        [Test]
        // Test to check that diesel powertrain adds 5000 to total cost with correct description
        public void PowertrainDecorator_WithDiesel_ShouldAdd_5000_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            var powertrainDecorator = new PowertrainDecorator(baseCar, Powertrain.Diesel);

            // Act
            var cost = powertrainDecorator.GetCost();
            var description = powertrainDecorator.GetDescription();

            // Assert
            Assert.That(cost, Is.EqualTo(15000)); // 10,000 base + 5000 for diesel
            Assert.That(description, Is.EqualTo("Car configuration: with diesel powertrain,"));
        }

        [Test]
        // Test to check that wheel size and type add correct amount to total cost with correct description
        public void WheelSizeDecorator_21Alloy_ShouldAdd_2800_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            baseCar = new WheelSizeDecorator(baseCar, WheelSize.TwentyOneInch);
            baseCar = new WheelTypeDecorator(baseCar, WheelType.Alloy);

            // Act
            var cost = baseCar.GetCost();
            var description = baseCar.GetDescription();

            // Assert
            Assert.That(cost, Is.EqualTo(12800)); // 10,000 base + 800 for 21" wheels + 2000 for alloys
            Assert.That(description, Is.EqualTo("Car configuration: with 21\" alloy wheels,"));
        }

        [Test]
        // Test to check that heated seats adds 2500 to total cost with correct description
        public void HeatedSeatsDecorator_ShouldAdd_2500_ToCost()
        {
            // Arrange
            Car baseCar = new BaseCar();
            var heatedSeatsDecorator = new HeatedSeatsDecorator(baseCar);

            // Act
            var cost = heatedSeatsDecorator.GetCost();
            var description = heatedSeatsDecorator.GetDescription();

            // Assert
            Assert.That(cost, Is.EqualTo(12500)); // 10,000 base + 2500 for heated seats
            Assert.That(description, Is.EqualTo("Car configuration: with heated seats"));
        }

        [Test]
        // Test to check that a full combination of decorators output the correct cost and description
        public void ChainMultipleDecorators_ShouldApplyAllCostsAndDescriptions()
        {
            // Arrange
            Car baseCar = new BaseCar();
            baseCar = new CarTypeDecorator(baseCar, CarType.Crossover);
            baseCar = new PowertrainDecorator(baseCar, Powertrain.Hybrid);
            baseCar = new PaintColourDecorator(baseCar, PaintColour.Black);
            baseCar = new PaintFinishDecorator(baseCar, PaintFinish.Metallic);
            baseCar = new WheelSizeDecorator(baseCar, WheelSize.NineteenInch);
            baseCar = new WheelTypeDecorator(baseCar, WheelType.Alloy);
            baseCar = new InteriorColourDecorator(baseCar, InteriorColour.White);
            baseCar = new InteriorMaterialDecorator(baseCar, InteriorMaterial.Suede);
            baseCar = new HeatedSeatsDecorator(baseCar);
            baseCar = new TouchScreenDecorator(baseCar);

            // Act
            var cost = baseCar.GetCost();
            var description = baseCar.GetDescription();

            // Assert
            decimal expectedCost = 10000 + 15000 + 10000 + 500 + 2000 + 400 + 2000 + 1000 + 8000 + 2500 + 1500;
            Assert.That(cost, Is.EqualTo(expectedCost));

            string expectedDescription = "Car configuration: Crossover with hybrid powertrain, with black metallic paint, with 19\" alloy wheels, with white suede interior with heated seats, with touch screen controls.";
            Assert.That(description, Is.EqualTo(expectedDescription));
        }
    }
}