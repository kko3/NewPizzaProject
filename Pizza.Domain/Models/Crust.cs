using Pizza.Domain.Interfaces;

namespace Pizza.Domain.Models
{
  public class Crust : IPizzaParts
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Cost { get; set; }
  }
}