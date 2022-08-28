using CalculatorModel = Model;

namespace Caculator.Tests;
public class CalculatorTest
{
  private CalculatorModel.Calculator _calc = new();

  [Fact]
  public void CalculatorSumsTwoNumbers()
  {
    var x = 5;
    var y = 10;
    var expected = x + y;

    var actual = (int)_calc.Add(x, y);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void CalculatorSubstractsOneNumberToOther()
  {
    var x = 10;
    var y = 5;
    var expected = x - y;

    var actual = (int)_calc.Subtract(x, y);

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void CalculatorMultipliesTwoNumbers()
  {
    float x = 99;
    float y = 100;
    var expected = x * y;

    var actual = _calc.Multiply(x, y);

    Assert.Equal(expected, actual, 5);
  }

  [Fact]
  public void CalculatorDividesTwoNumbers()
  {
    var x = 50;
    var y = 25;
    var expected = x / y;

    var actual = _calc.Divide(x, y);

    Assert.Equal(expected, actual, 2);

  }

  [Fact (Skip = "Intentional fail")]
  public void ForceAddFail()
  {
    // Arrange
    float x = 1;
    float y = x;
    var expected = x + y;

    // actual
    var actual = _calc.Add(x, y + 100);

    // assert
    Assert.Equal(expected, actual);
  }
}