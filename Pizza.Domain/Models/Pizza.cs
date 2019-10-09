using System.Collections.Generic;

namespace Pizza.Domain.Models
{
  public class Pizza
  {
    public int Id { get; set; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    public decimal Cost { get; set; }
    public static int LowerToppingLimit { get; set; }
    public static int UpperToppingLimit { get; set; }

    Pizza()
    {
      List<Topping> Toppings = new List<Topping>();
    }
  }
}