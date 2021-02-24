using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine("@");
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list or find one item already on your list?");
      Console.WriteLine("Please type Add or View or Find:");

      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "add")
      {
        // Perform the corresponding function
        // This will add a new item
        Console.WriteLine("Add a description for the new item:");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        // Console.WriteLine(newItem.Description); // This outputs the description given
        Main();
      }
      else if (userInput.ToLower() == "view")
      {
        foreach (Item element in Item.GetAll())
        {
          Console.WriteLine(element.Description);
        }
        Main();
      }
      else if (userInput.ToLower() == "find")
      {
        // Ask the user for some word or words which appear in the to do list item's description
        Console.WriteLine("Enter a word or words to search for:");
        string needlePart = Console.ReadLine();
        // Call static Find method to search all _instances
        Console.WriteLine(Item.Find(needlePart));
        // Return message (full description if found, not found message when not found) and print message to Console
        Main();
      }
      
    }
  }
}