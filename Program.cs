using System;
using System.Collections.Generic;
using InheritanceDiner.Models;

namespace InheritanceDiner
{
  class Program
  {
    static void Main(string[] args)
    {

      //int x = 7;
      //float y = (float)x;

      Console.WriteLine("Hello World!");
      Server Jessie = new Server("Jessie", "2k3j2k3n2");
      Supervisor Porter = new Supervisor("Porter", "k241k32");
      Manager Mark = new Manager("Mark", "23kh4kj32", 1111);
      Cook Darryl = new Cook("D$", "321kj23");

      List<Employee> Employees = new List<Employee>(){
        Jessie,
        Porter,
        Mark,
        Darryl
      };
      Employees.ForEach(e =>
      {
        System.Console.Write(e.Name + ": ");
        e.Discount();
        if (e is Manager)
        {
          System.Console.WriteLine(e.Name + " is the boss!");
          Manager m = (Manager)e;
          m.Delegate();
        }
      });
    }
  }
}
