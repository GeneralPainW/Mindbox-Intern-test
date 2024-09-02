using Mindbox_Intern_test;

namespace TestProject1
{
    public class CircleTests
    {
        [Fact]
        public void Circle_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Fact]
        public void Circle_WithZeroRadius_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void Calculate_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(2);
            var expectedArea = Math.PI * 4; 

            // Act
            var area = circle.Calculate();

            // Assert
            Assert.Equal(expectedArea, area, 5); 
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void Triangle_WithNegativeSides_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
        }

        [Fact]
        public void Triangle_WithZeroSides_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
        }

        [Fact]
        public void Triangle_WithInvalidSides_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Fact]
        public void Calculate_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6; 

            // Act
            var area = triangle.Calculate();

            // Assert
            Assert.Equal(expectedArea, area, 5); 
        }

        [Fact]
        public void IsRightAngle_WithRightAngleTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngle = triangle.IsRightAngle();

            // Assert
            Assert.True(isRightAngle);
        }

        [Fact]
        public void IsRightAngle_WithNonRightAngleTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(5, 5, 5);

            // Act
            var isRightAngle = triangle.IsRightAngle();

            // Assert
            Assert.False(isRightAngle);
        }
    }
}