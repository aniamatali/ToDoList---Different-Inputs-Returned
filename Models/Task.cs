using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Task
  {
    private string _make;
    private string _model;
    private int _price;

    private static List<string> _instances = new List<string> {};


    //this is the constructor
    public Task (string make, string model, int price)
    {
      _make = make;
      _model = model;
      _price = price;
    }

    public string GetMake()
    {
      return _make;
    }
    public void SetMake(string newMake)
    {
      _make = newMake;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void GetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add((_make + " " + _model + " " + _price));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
