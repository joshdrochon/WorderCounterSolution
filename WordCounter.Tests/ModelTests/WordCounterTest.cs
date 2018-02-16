using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject.Models;
using WordCounterProject;
using System.Collections.Generic;
using System;

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
    public void WorCounter_Reset()
    {
      int expectedResult = 0;
      int actualResult = WordCounter.Reset();
      Assert.AreEqual(expectedResult, actualResult);
    }
  }
}
