using NUnit.Framework;
using TextFilter;

namespace TextFilterNUnitTests
{
    public class ContainLetterTest
    {
        [Test]
        public void Contain_Letter_Return_True()
        {
            // Arrange
            var word = "Start";
            string letter = "t";

            // Act
            var filter = Filter.ContainsLetter(word, letter);

            // Assert
            Assert.AreEqual(filter, true);
        }

        [Test]
        public void Contain_Letter_Return_False()
        {
            // Arrange
            var word = "Start";
            string letter = "f";

            // Act
            var filter = Filter.ContainsLetter(word, letter);

            // Assert
            Assert.AreEqual(filter, false);
        }
    }
}