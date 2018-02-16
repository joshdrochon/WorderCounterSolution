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
      int expectedCounterVal = 1;
      WordCounter testCalcPass = new WordCounter();
      //act
      int actualCounterVal = testCalcPass.WordCounterCalc
      ("random", "This is a random sentence.");
      //assert
      Assert.AreEqual(expectedCounterVal, actualCounterVal);
    }
  }
}
