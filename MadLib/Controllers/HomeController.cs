using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult MadLib() 
    {
      return View();
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
      basicMadLib.Name = basicMadLib.Simon(name);
      basicMadLib.Verb = basicMadLib.Verbs(verb);
      return View(basicMadLib);
    }
    [Route("/dragonform")]
    public ActionResult DragonForm()
    {
      return View();
    }
    [Route("/puppyform")]
    public ActionResult PuppyForm()
    {
      return View();
    }
    [Route("/dragonmadlib")]
    public ActionResult DragonMadLib(string name, string verb)
    {
      DragonMadLibVariable dasicMadLib = new DragonMadLibVariable();
      dasicMadLib.Name = dasicMadLib.Simon(name);
      dasicMadLib.Verb = dasicMadLib.Verbs(verb);
      return View(dasicMadLib);
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
