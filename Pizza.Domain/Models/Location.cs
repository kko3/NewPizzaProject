using System.Collections.Generic;

namespace Pizza.Domain.Models
{
    public class Location
    {
      List<Order> OrdersAtStore { get; set; }

      Location()
      {
        List<Order> OrdersAtStore = new List<Order>();
      }
    }
}