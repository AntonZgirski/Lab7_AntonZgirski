using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab7
{
  class Program
  {
    static void Main(string[] args)
    {
      Pair<int, int> par = new Pair<int, int>(10,23);
      Console.WriteLine(par.SumPair());

      ComparablePair<int, int> com = new ComparablePair<int, int>(10, 15);
      ComparablePair<int, int> com2 = new ComparablePair<int, int>(10, 15);
      Console.WriteLine(com.CompareTo(com2));
      
    }
  }

  class Pair<S,T> where S : struct where T : struct
  {
    public S s { get; set; }
    public T t { get; set; }

    public Pair(S s, T t)
    {
      this.s = s;
      this.t = t;
    }

    public string SumPair()
    {
      return $"{this.s}  {this.t}";
    }
  }

  public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>> where T : IComparable where U : IComparable
  {
    public T t { get; set; }
    public U u { get; set; }

    public ComparablePair(T t, U u)
    {
      this.t = t;
      this.u = u;
    }

    public int CompareTo(ComparablePair<T,U> obj1)
    {
      var a = this.t.CompareTo(obj1.t);
      return a != 0 ? a : this.u.CompareTo(obj1.u);
    }
  }
}
