using NUnit.Framework;
using TextFilter;

namespace TextFilterNUnitTests
{
    public class LengthCheckTest
    {
        [Test]
        public void Length_Check_Return_False()
        {
            // Arrange
            var word = "Start";
            int length = 3;

            // Act
            var filter = Filter.LengthCheck(word, length);

            // Assert
            Assert.AreEqual(filter, false);
        }

        [Test]
        public void Length_Check_Return_True()
        {
            // Arrange
            var word = "To";
            int length = 3;

            // Act
            var filter = Filter.LengthCheck(word, length);

            // Assert
            Assert.AreEqual(filter, true);
        }

        [Test]
        public void Word_Blank_Return_True()
        {
            // Arrange
            var word = "";
            int length = 3;

            // Act
            var filter = Filter.LengthCheck(word, length);

            // Assert
            Assert.AreEqual(filter, true);
        }
    }
}