namespace MadLib.Models
{
  public class DragonMadLibVariable
  {
    public string Simon(string Name)
    {
      if (Name == "Simon")
      {
        Name = "archipelago";        
      }
      else if (Name == "Thomas")
      {
        Name = "did you mean to say Simon?";
      }
      return Name;

    }
    public string Verbs(string Verb)
    {
      if (Verb.Contains("a"))
      {
        Verb = Verb.Replace("a", "aaaa");
      }

      return Verb;
    }
    public string Name { get; set; }

    public string Verb {get; set; }

  }
}