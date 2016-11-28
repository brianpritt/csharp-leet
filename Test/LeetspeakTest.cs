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
    [Fact]
    public void LeetspeakTranslator_replaceO_true()
    {
      //Arrange
      string expectedResult = "t03";
      LeetspeakTranslator instance = new LeetspeakTranslator("toe");
      //Act
      string result = instance.Translate();
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void LeetspeakTranslator_replaceI_true()
    {
      //Arrange
      string expectedResult = "1 r0d3";
      LeetspeakTranslator instance = new LeetspeakTranslator("I rode");
      //Act
      string result = instance.Translate();
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void LeetspeakTranslator_replaceS_true()
    {
      //Arrange
      string expectedResult = "Sh3 r0z3";
      LeetspeakTranslator instance = new LeetspeakTranslator("She rose");
      //Act
      string result = instance.Translate();
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
