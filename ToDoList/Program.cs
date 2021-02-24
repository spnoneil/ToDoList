using System;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list (Add/View)");
      string userInput1 = (Console.ReadLine()).ToLower();
      Item testItem = new Item("Walk the Dog");
      if (userInput1 == "add")
      {
        Add();
        Repeat();
      }
      else if (userInput1 == "view")
      {
        View();
        Repeat();
      }
      Console.ReadLine();
    }
    public static void Add()
    {
        Console.WriteLine("Please enter the description for the new item.");
        string itemToAdd = Console.ReadLine();
        Item addedItem = new Item(itemToAdd);
        Console.WriteLine(itemToAdd + " has been added to your list.");
    }
    public static void Repeat()
    {
      Console.WriteLine("Would you like to add another item to your list or view your list (Add/View):");
        string userInput2 = (Console.ReadLine()).ToLower();
        if (userInput2 == "add")
        {
          Add();
        }
        else if (userInput2 == "view")
        {
          View();
        }
    }
    public static void View()
    {
      Console.WriteLine("Here are your To Do List Items:");
      foreach (Item element in Item.GetAll())
      {
        Console.WriteLine(element.Description);
      }
    }
  }
}