using System;
using doll.Models;

namespace doll {
  class Program {
    static void Main(string[] args) {
      Doll vader = new Doll("Vader");
      Doll trooper = new Doll("Storm Trooper");
      Doll tarken = new Doll("Grand Moff Tarken");
      Doll pilot = new Doll("Pilot");
      Doll raider = new Doll("Raider");
      Doll luke = new Doll("Luke");

      vader.Inner = trooper;
      trooper.Inner = tarken;
      tarken.Inner = pilot;
      pilot.Inner = raider;

      // insert Luke between Trooper and Tarken
      luke.Outer = trooper;
      luke.Inner = tarken;

      Console.WriteLine(tarken.Name);
      Console.WriteLine(tarken.Outer.Name);
      Console.WriteLine(tarken.Inner.Name);


      Console.WriteLine("\n\nOn to people!");

      Person ma = new Person("Luci");
      Person pa = new Person("Jim");
      Person michael = new Person("Michael", ma, pa);
      Person chris = new Person("Chris", ma, pa);
      Person john = new Person("John", ma, pa);
      chris.AddSibling(michael);
      michael.AddSibling(chris);
      john.AddSibling(michael);


      Console.WriteLine("Chris' brother Michael's siblings:");
      chris.GetSibling("Michael").GetSiblings().ForEach(sibling => Console.WriteLine(sibling.Name));
    }
  }
}
