using CalculatorModel = Model;

namespace Caculator.Tests
{
  public class TypeTests
  {
    [Fact]
    public void Test1()
    {
      var calcHandler1 = new CalculatorModel.CalculatorHandler();
      calcHandler1.CalculateFromString("1", "1", "+");

      var memory1 = calcHandler1.GetMemory(0);

      CalculatorModel.Memory expected = GetAdditionMemory();

      Assert.Equal(memory1.A, expected.A);
      Assert.Equal(memory1.B, expected.B);
      Assert.Equal(memory1, expected);
    }

    [Fact]
    public void TwoVarsReferenceSameObject()
    {
      var calcHandler1 = new CalculatorModel.CalculatorHandler();
      calcHandler1.CalculateFromString("1", "1", "+");

      var memory1 = calcHandler1.GetMemory(0);

      var memory2 = memory1;

      Assert.Equal(memory1.A, memory2.A);
      Assert.Equal(memory1.B, memory2.B);
      Assert.Equal(memory1, memory2);
    }

    public CalculatorModel.Memory GetAdditionMemory()
    {
      var calcHandler = new CalculatorModel.CalculatorHandler();
      calcHandler.CalculateFromString("1", "1", "+");

      return calcHandler.GetMemory(0);
    }

  }
}