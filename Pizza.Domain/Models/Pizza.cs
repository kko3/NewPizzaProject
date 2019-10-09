using System.Collections.Generic;

namespace Pizza.Domain.Models
{
  public class Pizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    public decimal Cost { get; set; }

    Pizza()
    {
      List<Topping> Toppings = new List<Topping>();
    }
  }
}