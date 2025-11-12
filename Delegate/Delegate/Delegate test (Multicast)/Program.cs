using System;

public class Calculator
{
    public delegate void MyCalculator(float x, float y);

    public MyCalculator _MathOp;

    public void Calaculate(float x, float y)
    {

        if (_MathOp != null)
        {
            _MathOp(x, y);
        }
    }


}


public delegate void MyDelegate(string message);
class Program
{
  static public  void Add(float x,float y)
    {
        Console.WriteLine((x + y));
    }

    static public void Sub(float x, float y)
    {
        Console.WriteLine((x - y));
    }


    static public void Dev(float x, float y)
    {
        Console.WriteLine((x / y));
    }

    static public void Mul(float x, float y)
    {
        Console.WriteLine((x * y));
    }
    static void Main()
    {
        MyDelegate myDelegate = Method1;
        myDelegate += Method2;


        myDelegate("Hello, world!");


        myDelegate -= Method1;
        myDelegate("Another message.");


        Calculator calculator = new Calculator();

        calculator._MathOp += Add;
        calculator._MathOp += Sub;
        calculator._MathOp += Mul;
        calculator._MathOp += Dev;
        calculator.Calaculate(10, 5);
    }


    static void Method1(string message)
    {
        Console.WriteLine("Method1: " + message);
    }


    static void Method2(string message)
    {
        Console.WriteLine("Method2: " + message);
    }
}
