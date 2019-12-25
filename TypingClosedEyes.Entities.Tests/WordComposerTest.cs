using System;
using TypingClosedEyes.Entities.Abstract;
using TypingClosedEyes.Entities.Concrete;
using TypingClosedEyes.Entities.Interface;
using Xunit;

namespace TypingClosedEyes.Entities.Tests
{
    public class WordComposerTest
    {
        [Fact]
        public void GetPropertyCount()
        {
            // Arrange
            A1Level a1Level = new A1Level();
            var randomProperty = new RandomProperty<LevelBase>();
            var x= randomProperty.GetRandomProperty();
            Assert.Equal(1, 1);
            
            // Act

            // Assert

        }
    }
}
