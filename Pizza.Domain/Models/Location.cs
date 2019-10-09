using System.Collections.Generic;

namespace Pizza.Domain.Models
{
    public class Location
    {
      public int Id { get; set; }
      public List<Order> OrdersAtStore { get; set; }
      public decimal TotalSales { get; set; }

      Location()
      {
        List<Order> OrdersAtStore = new List<Order>();
      }
    }
}