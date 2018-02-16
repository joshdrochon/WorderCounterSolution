using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject.Models;
using WordCounterProject;
using System.Collections.Generic;
using System;

namespace WordCounterProject.Test
{
  [TestClass]
  public class WorderCounterTest : IDispable
  {
    public void Dispose()
    {
      WordCounter.Reset();
    }
  }
}
