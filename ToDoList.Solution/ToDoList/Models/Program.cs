using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list?");
      Console.WriteLine("Please type Add or View:");

      List<Item> TodoList = new List<Item> {};

      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "add")
      {
        // Perform the corresponding function
        // This will add a new item
        Console.WriteLine("Add a description for the new item:");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Console.WriteLine(newItem.Description); // This outputs the description given
        Main();
      }
      else if (userInput.ToLower() == "view")
      {
        // Console.WriteLine(Models.Item.GetAll());
      }
    }
  }
}