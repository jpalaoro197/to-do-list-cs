using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> {};
    public Item(string description)
    public static List<Item> GetAll()
    {
      return _instances;
    }
    {
      Description = description;
      _instances.Add(this);
    }

  }
}