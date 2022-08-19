using System;

//zad1
/*class Fraction{
  private int enumerator;
  private int denominator;

  public Fraction(int e, int d){
    this.enumerator=e;
    if (d!=0){
    this.denominator=d;
    }
    else{
    Console.WriteLine("ivalid value");
    }
  }

  public void print(){
  Console.WriteLine(this.enumerator);
  Console.WriteLine(this.denominator);
  }
}*/

//zad2
/*class Delivery{
  private double packageWeight;
  private double packagePrice;
  private bool isUrgent;

  public Delivery(double w, double p, bool u){
    this.packageWeight=w;
    this.packagePrice=p;
    this.isUrgent=u;
  }

  public void print(){
    Console.WriteLine(this.packageWeight);
    Console.WriteLine(this.packagePrice);
    Console.WriteLine(this.isUrgent);
  }
}*/

//zad3
/*class Ship{
  private string type;
  private double weight;
  private double length;
  private string cargoType;
  private string companyName;

  public Ship(string t, double w, double l, string ct, string cn){
    this.type=t;
    this.weight=w;
    this.length=l;
    this.cargoType=ct;
    this.companyName=cn;
  }

  public void print(){
    Console.WriteLine(this.type);
    Console.WriteLine(this.weight);
    Console.WriteLine(this.length);
    Console.WriteLine(this.cargoType);
    Console.WriteLine(this.companyName);
  }
}*/

//zad4
class User{
  private string userName;
  private string password;
  private string registrationDate;
  private string gender;

  public User(string un, string p, string r, string g){
    this.userName=un;
    this.password=p;
    this.registrationDate=r;
    this.gender=g;
  }

  public void print(){
    Console.WriteLine(this.userName);
    Console.WriteLine(this.password);
    Console.WriteLine(this.registrationDate);
    Console.WriteLine(this.gender);
}
}

class Program {
  public static void Main (string[] args) {

   //zad1 
  /*int e = int.Parse(Console.ReadLine());
  int d = int.Parse(Console.ReadLine());
  Fraction fraction = new Fraction(e, d);
  fraction.print();*/

  //zad2
  /*double w = double.Parse(Console.ReadLine());
  double p = double.Parse(Console.ReadLine());
  bool u = Convert.ToBoolean(Console.ReadLine());
  Delivery delivery = new Delivery(w, p , u);
  delivery.print();*/

  //zad3
  /*string t = Console.ReadLine();
  double w = double.Parse(Console.ReadLine());
  double l = double.Parse(Console.ReadLine());
  string ct = Console.ReadLine();
  string cn = Console.ReadLine();
  Ship ship = new Ship(t, w, l, ct, cn);
  ship.print();*/

  //zad4
  string un = Console.ReadLine();
  string p = Console.ReadLine();
  string r = Console.ReadLine();
  string g = Console.ReadLine();
  User user = new User(un, p, r, g);
  user.print();
  }
}
