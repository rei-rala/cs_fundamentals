using System;
using Model;

var calculator = new Calculator();
var calc = new CalculatorHandler();

var first = calc.Calculate();
Console.WriteLine("First result: " + first);

calc.PrintMemory();
