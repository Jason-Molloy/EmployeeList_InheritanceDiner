namespace InheritanceDiner.Models
{
  class Manager : Supervisor
  {

    int PinCode { get; set; }
    public override void Discount()
    {
      System.Console.WriteLine("A 50% discount!!");
    }
    public void TerminateEmployee()
    {

    }
    public void HireEmployee()
    {

    }
    public void Delegate()
    {
      System.Console.WriteLine("Do my work!");
    }
    public Manager(string name, string id, int pin) : base(name, id)
    {
      PinCode = pin;
    }
  }
}

// Burger Shack - Afternoon Challenge
//Food AbstractClass
//     Entree
//           Burger
//     Sides
//           Fries
//           Tots
//Drink 
//        Fountain
//        MilkShake
//        Spirits(?)

//      Goal...
//            #1- CheeseBurger
//            #2- Waffle Fries
//            #3- Soft Drink