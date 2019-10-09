using System.Collections.Generic;

namespace Pizza.Domain.Models
{
  public class Order
  {
    public int Id { get; set; }
    public List<Pizza> PizzasOnOrder { get; set; }
    public decimal OrderCost { get; set; }
    public static decimal CostLimit { get; set; }
    public static int PizzaLimit { get; set; }
    public bool isComplete { get; set; }

    Order()
    {
      List<Pizza> PizzasOnOrder = new List<Pizza>();
    }
  }
}