using System;
using System.Collections.Generic;

namespace WordCounterProject.Models
{
  public class WordCounter
  {
    public static int _counter = 0;

    public static int reset()
    {
      return _counter = 0;
    }

    public int WordCounterCalc(string Word, string Phrase)
    {
      string userWord = Word.ToUpper();
      string userPhrase = Phrase;

      string[] userPhraseArray = userWord.Split(' ');

      foreach(var word in userPhraseArray) //word stands for each element in array
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
  }
}
