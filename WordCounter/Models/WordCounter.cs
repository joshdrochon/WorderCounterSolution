using System;
using System.Collections.Generic;

namespace WordCounterProject.Models
{
  public class WordCounter
  {
    public static int _counter = 0;

    public static int Reset()
    {
      return _counter = 0;
    }


    public int WordCounterCalc(string _word, string _phrase)
    {
      string userWord = _word.ToUpper();
      string userPhrase = _phrase.ToUpper();

      string[] userPhraseArray = userPhrase.Split(' ');

      //word stands for each element in array
      foreach(var word in userPhraseArray)
      {

        if(userWord == word)
        {
          _counter++;
          Console.WriteLine("The counter received 1 count for the word: " + word);
        }
        else
        {
          Console.WriteLine("The counter received 0 counts for the word: " + word);
        }
      }
      return _counter;
    }

    public int GetCounter()
    {
      return _counter;
    }

  }
}
