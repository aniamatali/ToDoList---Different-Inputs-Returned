using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Task
  {
    private string _description;
    private string _name;
    private string _make;

    private static List<string> _instances = new List<string> {};


    //this is the constructor
    public Task (string description, string name, string make)
    {
      _description = description;
      _name = name;
      _make = make;
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetMake()
    {
      return _make;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add((_description + " " + _name + " " + _make));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
