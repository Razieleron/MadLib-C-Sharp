using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    //this is gonna be um, the foundation for the madlib and what have you
    [Route("/")]
    public ActionResult MadLib() 
    {
      MadLibVariable basicMadLib = new MadLibVariable();
      basicMadLib.Name = "haha";
      basicMadLib.Verb = "jump";
      return View(basicMadLib);
    }

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/filledinmadlib")]
    public ActionResult FilledInMadLib(string name, string verb)
    {
      MadLibVariable basicMadLib = new MadLibVariable();
      basicMadLib.Name = name;
      basicMadLib.Verb = verb;
      return View(basicMadLib);
    }

    // [Route("/")]
    // public ActionResult Letter() { 
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Jasmine";
    //   return View(myLetterVariable); }

    // [Route("/form")]
    // public ActionResult Form() { return View(); }

    // [Route("/postcard")]
    // public ActionResult Postcard(string recipient, string sender)
    // {
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = recipient;
    //   myLetterVariable.Sender = sender;
    //   return View(myLetterVariable);
    }

  }
