using System.Collections.Generic;

namespace Planner
{
  public class Store {
      public Store(string name, List<string> initialInventory) {
          Name = name;
          Inventory = initialInventory;
      }

      public string Name {get; set;}
      public List<string> Inventory {get; set;}

  }

}
