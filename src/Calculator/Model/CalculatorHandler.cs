namespace Model
{
  public class CalculatorHandler
  {
    private readonly Calculator _calculator = new();
    private readonly List<Memory> _memory = new();
    private static List<string> _operators = new List<string> { "+", "-", "*", "/" };

    public float CalculateFromString(string a, string b, string operatorSign)
    {
      var parsedFloatA = float.Parse(a);
      var parsedFloatB = float.Parse(b);
      float result = 0;

      switch (operatorSign)
      {
        case "+":
          result = _calculator.Add(parsedFloatA, parsedFloatB);
          break;
        case "-":
          result = _calculator.Subtract(parsedFloatA, parsedFloatB);
          break;
        case "*":
          result = _calculator.Multiply(parsedFloatA, parsedFloatB);
          break;
        case "/":
          result = _calculator.Divide(parsedFloatA, parsedFloatB);
          break;
        default:
          throw new Exception("Invalid operator");
      }

      _memory.Add(new Memory(parsedFloatA, parsedFloatB, operatorSign, result));

      return result;
    }

    public float Calculate()
    {
      string inputA, inputB, operatorSign;

      Console.WriteLine("Enter the first number: ");
      while (!float.TryParse(inputA = "" + Console.ReadLine(), out float a))
      {
        Console.WriteLine("Invalid input. Please enter a number: ");
      }

      Console.WriteLine("Enter the second number: ");
      while (!float.TryParse(inputB = "" + Console.ReadLine(), out float b))
      {
        Console.WriteLine("Invalid input. Please enter a number: ");
      }
      var parsedFloatB = float.Parse(inputB);

      Console.WriteLine("Enter the operator: ");
      while (!_operators.Contains(operatorSign = "" + Console.ReadLine()))
      {
        Console.WriteLine("Invalid input. Please enter an operator: ");
      }

      return CalculateFromString(inputA, inputB, operatorSign);
    }

    public void PrintMemory()
    {
      if (_memory.Count == 0)
      {
        Console.WriteLine("No memory to print");
        return;
      }

      foreach (var memory in _memory)
      {
        Console.WriteLine(memory);
      }
    }

    public Memory GetMemory(int index)
    {
      Memory selected = _memory[index];
      return selected;
    }

    public void PrintMemory(int index)
    {
      var memory = GetMemory(index);
      Console.WriteLine(memory == null ? $"No memory at index {index}" : memory);
    }



  }
}