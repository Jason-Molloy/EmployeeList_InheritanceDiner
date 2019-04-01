namespace InheritanceDiner.Models
{
  abstract class Employee
  {
    public string Name { get; set; }
    public string Id { get; set; }
    public void ClockIn()
    {

    }
    public void ClockOut()
    {

    }
    public virtual void Discount()
    {
      System.Console.WriteLine("A 5% discount!!");
    }
    public Employee(string name, string id)
    {
      Name = name;
      Id = id;
    }
  }
}