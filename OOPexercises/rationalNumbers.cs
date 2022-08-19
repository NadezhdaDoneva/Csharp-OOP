using System;

//zad1
class Rational{
  private double enumerator1;
  private double denominator1;
  private double enumerator2;
  private double denominator2;

  public void setEnum1(double e1){
    this.enumerator1=e1;
  }
  public double getEnum1(){
    return this.enumerator1;
  }
  public void setDenom1(double d1){
    if (d1!=0){
      this.denominator1=d1;
    }
    else{
      this.denominator1=0;
    }
  }
  public double getDenom1(){
    return this.denominator1;
  }

  public void setEnum2(double e2){
    this.enumerator2=e2;
  }
  public double getEnum2(){
    return this.enumerator2;
  }
  public void setDenom2(double d2){
    if (d2!=0){
      this.denominator2=d2;
    }
    else{
      this.denominator2=1;
    }
  }
  public double getDenom2(){
    return this.denominator2;
  }

  public Rational (double e1, double d1, double e2, double d2){
    this.enumerator1=e1;
    if (d1!=0){
      this.denominator1=d1;
    }
    else {this.denominator1=1;
  }
  this.enumerator2=e2;
   if (d2!=0){
      this.denominator2=d2;
    }
    else {
      this.denominator2=1;
  }
 }
  
  public Rational(Rational r){
    this.enumerator1=r.enumerator1;
    this.enumerator2=r.enumerator2;
    this.denominator1=r.denominator1;
    this.denominator2=r.denominator2;
  }

  public void print(){
    Console.WriteLine("adiition: "+ (this.enumerator1*this.denominator2 + this.denominator1*this.enumerator2)/(this.denominator1*this.denominator2));
    Console.WriteLine("substraction: "+ (this.enumerator1*this.denominator2 - this.denominator1*this.enumerator2)/(this.denominator1*this.denominator2));
  }
}


class Program {
  public static void Main (string[] args) {
    
    //zad1
    double e1 = int.Parse(Console.ReadLine());
    double d1 = int.Parse(Console.ReadLine());
    double e2 = int.Parse(Console.ReadLine());
    double d2 = int.Parse(Console.ReadLine());

    Rational drop1 = new Rational(e1,d1,e2,d2);
    Rational drop2 = new Rational(e1,d1,e2,d2);
    Rational drop3 = new Rational(drop2);

    drop1.print();
    drop2.print();
    drop3.print();
  }
}