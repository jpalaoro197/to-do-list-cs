using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace Program.ToDoList
{
  public class Program
  {
    public static Dictionary<string
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List, Would you like to add an item to your list or view your list? (Add/View)");
      string response = Console.ReadLine();
      if (response == "Add" || response == "add")
      {
        Console.WriteLine("What would you like to add?");
      } else if (response == "View" || response == "view") {
        Console.WriteLine("Here's your current to do list");
      } else {
        Console.WriteLine("Please use 'Add' or 'View'");
      }
      string userTask = Console.ReadLine();
      Item userItem = new Item(userTask);
      List<Item> newList = new List<Item> {};
      List<Item> result = Item.GetAll();
      Console.WriteLine(result);
      Main();
    }
  }
}