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
      int counter = 0;

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
        else if(character == 'I')
        {
          result = result + "1";
        }
        else if (character == 's' || character == 'S')
        {
          if (counter == 0)
          {
            result = result + character;
          }
          else if (array[counter-1] == ' ')
          {
            result = result + character;
          }
          else
          {
            result = result + "z";
          }
        }
        else
        {
          result = result + character;
        }
        counter++;
      }
      return result;
    }
  }
}
