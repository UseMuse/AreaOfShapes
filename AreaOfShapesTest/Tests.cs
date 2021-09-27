using AreaOfShapes.Shapes;
using AreaOfShapes.Сalculators.Area;
using NUnit.Framework;
using System;

namespace AreaOfShapesTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10, new CalculatedArea()));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            CalculatedArea calcArea = new CalculatedArea();
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0, calcArea));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0, calcArea));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10, calcArea));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10, calcArea));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            Circle circle = new Circle(10, new CalculatedArea());

            //Act
            double? circleSquare = circle.Area();

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5, new CalculatedArea());

            //Act
            double? triangleSquare = triangle.Area();

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5, new CalculatedArea());

            //Act
            bool isTriangleRightAngled = triangle.IsRightAngled();

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            Triangle triangle = new Triangle(6, 2, 5, new CalculatedArea());

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled();

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
