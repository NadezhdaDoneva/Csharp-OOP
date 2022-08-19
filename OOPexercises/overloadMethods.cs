using System;

class Math
{
  public double sum(double a, double b)
  {
    return a+b;
  }
  
  public double sum(double a, double b, double c)
  {
    return a+b+c;
  }

  public double sum(double a, double b, double c, double d)
  {
    return a+b+c+d;
  }

  public double sum(double a, double b, double c, double d, double e)
  {
    return a+b+c+d+e;
  }

  public void multiply(int a, string str)
  {
     for (int i=1; i<=a; i++)
    {
      Console.WriteLine(str);
    }
  }

  public void multiply (int a, int b)
  {
    Console.WriteLine(a*b);
  }

  public void permutation(int a, int b)
  {
    for (int i=1; i<a; i++)
    {
      i=i*i;
    }
  }
}

class Program {
  public static void Main (string[] args) {
    
    Math mySum = new Math();
    mySum.sum(1,2);
    Console.WriteLine(mySum.sum(1, 2));
    mySum.sum(1,2,3);
    Console.WriteLine(mySum.sum(1, 2,3));
    mySum.sum(1,2,3,4);
    Console.WriteLine(mySum.sum(1, 2,3,4));
    mySum.sum(1,2,3,4,5);
    Console.WriteLine(mySum.sum(1, 2,3,4,5));

    Math myMultiply = new Math();
    myMultiply.multiply(3, "Hello!");
    myMultiply.multiply(2,3);

    
  }
}