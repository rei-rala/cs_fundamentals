namespace Model
{
  public class Memory
  {
    private static int counter = 0;
    public int OpNumber;
    public float A { get; }
    public float B { get; }
    public string OperatorSign;
    public float Result { get; }

    public Memory(float a, float b, string operatorSign, float result)
    {
      OpNumber = counter++;
      A = a;
      B = b;
      OperatorSign = operatorSign;
      Result = result;
    }

    public override string ToString()
    {
      return $"{OpNumber} => {A} {OperatorSign} {B} = {Result}";
    }

    public override bool Equals(object? other)
    {
      if (other == null) return false;
      if (other.GetType() == this.GetType())
      {
        Memory otherAsMemory = (Memory)other;

        return (
          otherAsMemory.A == this.A &&
          otherAsMemory.B == this.B &&
          otherAsMemory.OperatorSign == this.OperatorSign
          );
      }
      return false;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(A, B, OperatorSign);
    }
  }
}