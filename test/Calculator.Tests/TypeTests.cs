using CalculatorModel = Model;

namespace Caculator.Tests
{
  public class TypeTests
  {

    [Fact]
    public void TwoSameValues()
    {
      var calcHandler1 = new CalculatorModel.CalculatorHandler();
      calcHandler1.CalculateFromString("1", "1", "+");

      var memoryFirstValue1 = calcHandler1.GetMemory(0).A;
      int expected = 1;

      Assert.Equal(memoryFirstValue1, expected);
    }

    [Fact]
    public void TwoVarsEqualsButNotSame()
    {
      var calcHandler1 = new CalculatorModel.CalculatorHandler();
      calcHandler1.CalculateFromString("1", "1", "+");

      var memory1 = calcHandler1.GetMemory(0);

      CalculatorModel.Memory expected = GetAdditionMemory();

      Assert.Equal(memory1, expected);
      Assert.NotSame(memory1, expected);
    }

    [Fact]
    public void TwoVarsReferenceSameObject()
    {
      var calcHandler1 = new CalculatorModel.CalculatorHandler();
      calcHandler1.CalculateFromString("1", "1", "+");

      var memory1 = calcHandler1.GetMemory(0);

      var memory2 = memory1;

      Assert.Same(memory1, memory2);
      Assert.True(Object.ReferenceEquals(memory1, memory2));
    }

    public CalculatorModel.Memory GetAdditionMemory()
    {
      var calcHandler = new CalculatorModel.CalculatorHandler();
      calcHandler.CalculateFromString("1", "1", "+");

      return calcHandler.GetMemory(0);
    }

    [Fact]
    public void CanSetMemoryReference()
    {
      var memory1 = GetAdditionMemory();
      var memory2 = GetAdditionMemory();

      GetMemorySetMemory(memory1);

      Assert.Equal(memory1, memory2);
    }

    public void GetMemorySetMemory(CalculatorModel.Memory m)
    {
      var calcHandler = new CalculatorModel.CalculatorHandler();
      calcHandler.CalculateFromString("999", "999", "/");

      m = calcHandler.GetMemory(0);
    }

    [Fact]
    public void CanSetMemoryReferenceValid()
    {
      var memory1 = GetAdditionMemory();
      var memory2 = GetAdditionMemory();

      GetMemorySetMemoryByReference(ref memory1);

      Assert.NotEqual(memory1, memory2);
    }

    public void GetMemorySetMemoryByReference(ref CalculatorModel.Memory m)
    {
      var calcHandler = new CalculatorModel.CalculatorHandler();
      calcHandler.CalculateFromString("999", "999", "/");

      m = calcHandler.GetMemory(0);
    }

  }
}