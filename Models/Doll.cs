namespace doll.Models {
  public class Doll {
    public string Name { get; private set; }

    private Doll _outer = null;
    public Doll Outer {
      get => _outer;
      set {
        if (_outer != null) {
          // _outer.Inner = null;
        }
        if (value.Inner != this) {
          value.Inner = this;
        }
        _outer = value;
      }
    }

    private Doll _inner = null;
    public Doll Inner {
      get => _inner;
      set {
        _inner = value;
        value.Outer = this;
      }
    }

    public Doll(string name) {
      Name = name;
    }
  }
}