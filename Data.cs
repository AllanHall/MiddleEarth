namespace MiddleEarth
{
  class Data
  {
    static void NotMain(string[] args)
    {
      var db = new LotrExplorationContext();
      db.Creatures.Add(new SeenCreatures
      {
        Species = "Goblin",
        CountOfTimesSeen = 52,
        LocationOfLastSeen = "Moria"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Troll",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Moria"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Orc",
        CountOfTimesSeen = 10000,
        LocationOfLastSeen = "Helm's Deep"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Ent",
        CountOfTimesSeen = 2,
        LocationOfLastSeen = "Isenguard"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Fell Beasts",
        CountOfTimesSeen = 9,
        LocationOfLastSeen = "Minas Tirith"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Warg",
        CountOfTimesSeen = 100,
        LocationOfLastSeen = "Rohan"
      });
      db.Creatures.Add(new SeenCreatures()
      {
        Species = "Watcher in the Water",
        CountOfTimesSeen = 1,
        LocationOfLastSeen = "Moria"
      });
      db.SaveChanges();
    }
  }
}