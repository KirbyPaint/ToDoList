using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public static List<Item> GetAll()
    {
      return _instances;
    }
    // We add set; to the line below.
    public string Description { get; set; }
    private static List<Item> _instances = new List<Item> { };

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }
  }
}