using System.Collections.Generic;

namespace doll.Models {
  public class Person {
    public string Name { get; set; }
    Person Ma;
    Person Pa;
    Dictionary<string, Person> Siblings = new Dictionary<string, Person>();

    public bool AddSibling(Person person) {
      if (Siblings.ContainsKey(person.Name)) {
        return false;
      }
      // new List<Person>(Siblings.Values).ForEach(sibling => person.AddSibling(sibling));
      person.AddSibling(this);
      Siblings.Add(person.Name, person);
      return true;
    }
    public List<Person> GetSiblings() {
      return new List<Person>(Siblings.Values);
    }
    public Person GetSibling(string name) {
      if (!Siblings.ContainsKey(name)) {
        return null;
      }
      return Siblings[name];
    }
    public Person(string name, Person ma = null, Person pa = null) {
      Name = name;
      Ma = ma;
      Pa = pa;
    }
  }
}