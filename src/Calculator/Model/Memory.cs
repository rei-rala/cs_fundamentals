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