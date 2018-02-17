using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;
using System;

namespace WordCounterProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("WordCounter/Result")]
    public ActionResult Result()
    {
      string inputWord = Request.Form["input-word"];
      string inputPhrase = Request.Form["input-phrase"];

      WordCounter newWordCounter = new WordCounter();

      int userCounter = newWordCounter.WordCounterCalc
      (inputWord, inputPhrase);

      return View("../WordCounter/Result", userCounter);
    }
  }
}
