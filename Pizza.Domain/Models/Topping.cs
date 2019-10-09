using Pizza.Domain.Interfaces;

namespace Pizza.Domain
{
  public class Topping : IPizzaParts
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
  }
}