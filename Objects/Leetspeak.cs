using System.Collections.Generic;

namespace Leetspeak.Objects
{
  public class LeetspeakTranslator
  {
    private string _inputString;

    public LeetspeakTranslator(string input)
    {
      _inputString = input;
    }
    public string Translate()
    {
      string result = "";
      char[] array = _inputString.ToCharArray();

      foreach (char character in array)
      {
        if (character == 'e' || character == 'E')
        {
          result = result + "3";
        }
        else if (character == 'o' || character == 'O')
        {
          result = result + "0";
        }
        else
        {
          result = result + character;
        }
      }
      return result;
    }
  }
}
