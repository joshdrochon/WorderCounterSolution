using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounterProject.Models;
using WordCounterProject;

namespace WordCounterProject.Test
{
  [TestClass]
  public class WorderCounterTest : IDisposable
  {
    public void Dispose()
    {
      WordCounter.Reset();
    }

    [TestMethod]
    public void WordCounter_Reset()
    {
      //arrange
      int expectedResult = 0;
      //act
      int actualResult = WordCounter.Reset();
      //assert
      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestCalc_Pass()
    {
      //arrange
      int expectedCountValPass = 1;
      WordCounter testCalcPass = new WordCounter();
      //act
      int actualCountValPass = testCalcPass.WordCounterCalc
      ("random", "This is a random sentence.");
      //assert
      Assert.AreEqual(expectedCountValPass, actualCountValPass);
    }

    [TestMethod]
    public void TestCalc_Fail()
    {
      //arrange
      int expectedCountValFail = 0;
      WordCounter testCalcFail = new WordCounter();
      //act
      int actualCountValFail = testCalcFail.WordCounterCalc
      ("like", "Hello, I like failing. Don't ask me why.");
      //assert
      Assert.AreEqual(expectedCountValFail, actualCountValFail);
    }


  }
}
