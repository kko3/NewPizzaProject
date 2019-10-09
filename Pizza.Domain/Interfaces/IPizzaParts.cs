namespace Pizza.Domain.Interfaces
{
  interface IPizzaParts
  {
    int Id { get; set; }
    string Name { get; set; }
    decimal Cost { get; set; }
  }   
}