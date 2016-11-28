using Xunit;
using System.Collections.Generic;
using System;
using Leetspeak.Objects;

namespace Leetspeak
{
  public class LeetspeakTest
  {
    [Fact]
    public void LeetspeakTranslator_replaceE_true()
    {
      //Arrange
      string expectedResult = "th3";
      LeetspeakTranslator instance = new LeetspeakTranslator("the");
      //Act
      string result = instance.Translate();

      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
