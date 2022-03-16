using NUnit.Framework;
using System.Collections.Generic;
using TextFilter;

namespace TextFilterNUnitTests
{
    public class ContainVowelsTest
    {
        [Test]
        public void Contains_Vowel_Return_True()
        {
            // Arrange
            var word = "Tesf";
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            // Act
            var filter = Filter.ContainsVowel(word, vowels);

            // Assert
            Assert.AreEqual(filter, true);
        }

        [Test]
        public void Contains_UpperCase_Vowel_Return_True()
        {
            // Arrange
            var word = "SAME";
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            // Act
            var filter = Filter.ContainsVowel(word, vowels);

            // Assert
            Assert.AreEqual(filter, true);
        }

        [Test]
        public void Contains_Vowel_Of_Length_2_Return_True()
        {
            // Arrange
            var word = "To";
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            // Act
            var filter = Filter.ContainsVowel(word, vowels);

            // Assert
            Assert.AreEqual(filter, true);
        }

        [Test]
        public void Contains_Vowel_Return_False()
        {
            // Arrange
            var word = "and";
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            // Act
            var filter = Filter.ContainsVowel(word, vowels);

            // Assert
            Assert.AreEqual(filter, false);
        }

        [Test]
        public void Contains_Character_Return_True()
        {
            // Arrange
            var word = "Encapsulate";
            var characters = new List<char> { 's', 't', 'c', 'a', 'k' };

            // Act
            var filter = Filter.ContainsVowel(word, characters);

            // Assert
            Assert.AreEqual(filter, true);
        }
    }
}