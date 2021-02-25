using System;
using System.Collections.Generic;
using System.Linq;

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
      Console.WriteLine("Please type Add or View or Find or press Enter for other options:");

      List<Item> allTasks = new List<Item> { };
      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "add")
      {
        // Perform the corresponding function
        // This will add a new item
        Console.WriteLine("Add a description for the new item:");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        // Console.WriteLine(newItem.Description); // This outputs the description given
        allTasks.Add(newItem);
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
        // If it returned true
        // Say we found your item(s)
        // then return items
        Console.WriteLine(Item.FindItem(needlePart));
        // Return message (full description if found, not found message when not found) and print message to Console
        Main();
      }

      Console.WriteLine("Would you like to change some of your task? ['yes', 'no']");
      string answer = Console.ReadLine().ToLower();
      if (answer == "yes")
      {
        Console.WriteLine("Please provide a task you would like to change");
        // User looks in the list for an item to change
        string taskToUpdate = Console.ReadLine().ToLower();
        // If the user's provided item is found in the list
        if ((Item.FindItem(taskToUpdate)) != "Your ToDo List Item could not be found")
        {

          List<string> searchMatches = new List<string> { };
          // EXAMPLE make list of strings: patientdata.Select(x=>x.Name)
          //                               ^list<obj>  ^yes   ^Name should be Description
          // searchMatches.Add(allTasks.Select( x => x.Description);

          // Add() will add the searched-for Item to a List<Item>

          searchMatches.Add("string");
          Item newItem = new Item(taskToUpdate);
          // searchMatches.Add(newItem);

          // Need to grab the item that we will be modifying
          // Grab the Item as the full Item and NOT just the string description
          // EXAMPLE MyClass result = list.Find(x => x.GetId() == "xy");
          // List<Item> searchMatches = allTasks.Find( x => x.Description.Contains(taskToUpdate));

          foreach (string element in searchMatches)
          {
            Console.WriteLine("Is {0} the item you would like to change?", element);
            string confirmChange = Console.ReadLine().ToLower();
            if (confirmChange == "yes")
            {
              Console.WriteLine("Please provide a new description for your task");
              // Take user's new description
              string newDescription = Console.ReadLine().ToLower();
              Item[0].Description = newDescription;
              // and pass it through to the selected list item
            }
          }

          // Use a lambda expression?
          // If the search function requires exact match, we can list out all possibilities for the user to confirm which one exactly, if there are more than one
        }
        else
        {
          Console.WriteLine("Sorry! There are nothing to update");
        }

      }



    }
  }
}