using System;

//zad1
class Rational{
  private int chisl;
  private int znam;

  public Rational (int c; int z;) {
  this.chisl=c;

  if (z!==0){
  this.znam=z;
  }
  else{
    Console.WriteLine("invalid value");
  }
  Console.WriteLine("Constructor with parameters");
  }

  public Rational (Rational r){
    this.chisl=r.chisl;
    this.znam= r.znam;
    Console.WriteLine("Copy constructor");
  }

  public void calc(double chislitel1, double znamenatel1, double chislitel2, double znamenatel2 ){
     Console.WriteLine("addition: " + (chislitel1*znamenatel2 + znamenatel1*chislitel2)/(znamenatel2*znamenatel1));
     Console.WriteLine("subtraction: " + (chislitel1*znamenatel2 - znamenatel1*chislitel2)/(znamenatel2*znamenatel1));
  }
}


class Program {
  public static void Main (string[] args) {
    
    //zad1
    int chislitel = int.Parse(Console.ReadLine());
    int znamenatel = int.Parse(Console.ReadLine());
    Rational r1 = new Rational(chislitel, znamenatel);
    int chislitel2 = int.Parse(Console.ReadLine());
    int znamenatel2 = int.Parse(Console.ReadLine());
    Rational r2 = new Rational(chislitel2, znamenatel2);
  }
}