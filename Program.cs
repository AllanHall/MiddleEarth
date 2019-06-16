using System;
using System.Linq;

namespace MiddleEarth
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = new LotrExplorationContext();
      {
        Console.WriteLine("Your quest stands upon the edge of a knife, these are the creatures you have encountered..");

        // Displaying all creatures user has seen
        var allCreatures = db.Creatures.OrderBy(o => o.Species);
        foreach (var creature in allCreatures)
        {
          Console.WriteLine($"{creature.Species}");
        }

        // Updating count of times seen and locationfor a creature
        var orc = db.Creatures.FirstOrDefault(f => f.Species == "Orc");
        orc.CountOfTimesSeen = orc.CountOfTimesSeen + 500;
        orc.LocationOfLastSeen = "Mordor";
        db.SaveChanges();

        // Displaying creatures in Moria
        var creaturesInMoria = db.Creatures.Where(c => c.LocationOfLastSeen == "Moria");
        Console.WriteLine("These are the creatures you encountered in Moria");
        foreach (var moriaCreature in creaturesInMoria)
        {
          Console.WriteLine($"{moriaCreature.Species}");
        }

        // Removing all creatures seen in Rohan
        var del = db.Creatures.FirstOrDefault(d => d.LocationOfLastSeen == "Rohan");
        if (del != null)
        {
          db.Creatures.Remove(del);
          db.SaveChanges();
        }

        // Total Number of Animals Seen
        var numberOfCreatures = db.Creatures.Where(w => w.CountOfTimesSeen > 0);
        int total = 0;
        foreach (var creature in numberOfCreatures)
        {
          total += creature.CountOfTimesSeen;
        }
        Console.WriteLine($"You have seen {total} creatures in Middle Earth");

        // Count of Times Seen of Ents, Trolls, and Goblins
        var ent = db.Creatures.FirstOrDefault(f => f.Species == "Ent");
        Console.WriteLine($"You have seen an {ent.Species} {ent.CountOfTimesSeen} times");
        var troll = db.Creatures.FirstOrDefault(o => o.Species == "Troll");
        Console.WriteLine($"You have seen a {troll.Species} {troll.CountOfTimesSeen} time");
        var goblin = db.Creatures.FirstOrDefault(d => d.Species == "Goblin");
        Console.WriteLine($"You have seen a {goblin.Species} {goblin.CountOfTimesSeen} times");
      }
    }
  }
}
