using System.Collections.Generic;

namespace Model
{
  public class Memory
  {
    private static int counter = 0;
    public float A { get; }
    public float B { get; }
    public string OperatorSign;
    public float Result { get; }

    public Memory(float a, float b, string operatorSign, float result)
    {
      this.A = a;
      this.B = b;
      this.OperatorSign = operatorSign;
      this.Result = result;
      counter++;
    }

    public override string ToString()
    {
      return $"{counter} => {A} {OperatorSign} {B} = {Result}";
    }

    public override bool Equals(object? obj)
    {
      if (obj == null) return false;
      if (obj.GetType() == this.GetType())
      {
        Memory objMemory = (Memory)obj;

        return (
          objMemory.A == this.A &&
          objMemory.B == this.B &&
          objMemory.OperatorSign == this.OperatorSign
          );
      }
      return false;
    }

  }
}