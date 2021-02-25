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

    public static string FindItem(string needle)
    {
      string message = "Your to do list item(s) has/have been found: ";
      bool itemFound = false;
      foreach(Item hay in Item.GetAll())
      {
        if (hay.Description.Contains(needle))
        {
          message += "\n" + hay.Description;
          itemFound = true;
        }
      }
      if (itemFound)
      {
        return message;
      }
      else
      {
        message = "Your ToDo List Item could not be found";
        return message;
      }
    }

    // public static string Update(string answer)
    // {
      
    // }
  }
}