namespace doll.Models {
  public class Doll {
    public string Name { get; private set; }

    public Doll Outer;
    public Doll Inner;

    public Doll(string name) {
      Name = name;
    }
  }
}