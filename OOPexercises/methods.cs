using System;
//zad1
/*class Triangle {
  public double area(double a, double h){
    if (a<0 || h<0){
      return -1;
    }
    else {
      return (a*h)/2;
    }
  }
}*/


//zad2
/*class Point{
  public double distance(double x1, double y1, double x2, double y2){
    return Math.Sqrt((y2-y1)*(y2-y1)+ (x2-x1)*(x2-x1));
  }
}*/


//zad3
/*class Employee{
  public void printEmployee(string fname, string lname, int age, string position){
    if (age<0){
      Console.WriteLine("Invalid value");
    }
    else{
      Console.WriteLine("Name: " + fname + " " + lname);
      Console.WriteLine("Age: " + age);
      Console.WriteLine("Position: " + position);
    }
  }
}*/


//zad4
/*class Trip{
  public int calcPrice(int days, int beds, int ticket=20, int edBeds = 40){
    return (edBeds*beds*days+2*ticket);
  }
}*/


//zad5
/*class Order{
  public void calcPrice(double pizza_price, int pizza_amount, double drink_price, int drink_amount, int delivery = 5){
    if (pizza_price<=0 || pizza_amount<=0 || drink_price<=0 || drink_amount<=0){
      Console.WriteLine("Invalid values");
    }
    else {
      Console.WriteLine("the price is: " + (pizza_price*pizza_amount+drink_price*drink_amount+delivery));
    }
  }
}*/


//zad6
/*class Equation{
  public void makeEquation(double p, double q){
    Console.WriteLine("x^2-"+ (p+q) + "x+"+ (p*q));
  }
}*/


//zad7
/*class Triplet{
  public bool checkP(double a, double b, double c){
  if (a*a+b*b==c*c){
    return true;
  }
  else{
    return false;
  }
  }
}*/


//zad8
/*class Average{
  public bool checkAverage(int[] arr1, int[] arr2, int sum1, int sum2){
    if (sum1/10==sum2/10){
      return true;
    }
    else {
      return false;
    }
  }
}*/


//zad9
class Series{
  public int series(int n){
    if (n<=3){
      return 1;
    }
    else{
      return series(n-1)+series(n-2)+series(n-3);
    }
  }
}

class Program {
  public static void Main (string[] args) {
    //zad1
    /*Triangle tr=new Triangle();
    double area;
    double a=double.Parse(Console.ReadLine());
    double h=double.Parse(Console.ReadLine());
    area= tr.area(a,h);
    Console.WriteLine(area);*/


  //zad2
  /*Point p=new Point();
  double d;
  double x1=double.Parse(Console.ReadLine());
  double y1=double.Parse(Console.ReadLine());
  double x2=double.Parse(Console.ReadLine());
  double y2=double.Parse(Console.ReadLine());
  d = p.distance(x1, y1, x2, y2);
  Console.WriteLine(d);*/


  //zad3
  /*Employee employee= new Employee();
  string fname=Console.ReadLine();
  string lname=Console.ReadLine();
  int age=Convert.ToInt32(Console.ReadLine());
  string position=Console.ReadLine();
  employee.printEmployee(fname, lname, age, position);*/


  //zad4
  /*Trip trip = new Trip();
  int price;
  int days = Convert.ToInt32(Console.ReadLine());
  int beds = Convert.ToInt32(Console.ReadLine());
  price = trip.calcPrice(days, beds);
  Console.WriteLine(price);*/


  //zad5
  /*Order order = new Order();
  double pizza_price = double.Parse(Console.ReadLine());
  int pizza_amount = Convert.ToInt32(Console.ReadLine());
  double drink_price = double.Parse(Console.ReadLine());
  int drink_amount = Convert.ToInt32(Console.ReadLine());
  order.calcPrice(pizza_price, pizza_amount, drink_price, drink_amount);*/


  //zad6
  /*Equation equation = new Equation();
  double p= double.Parse(Console.ReadLine());
  double q= double.Parse(Console.ReadLine());
  equation.makeEquation(p,q);*/


  //zad7
  /*Triplet triplet = new Triplet();
  double a =  double.Parse(Console.ReadLine());
  double b= double.Parse(Console.ReadLine());
  double c= double.Parse(Console.ReadLine());
  Console.WriteLine(triplet.checkP(a,b,c));*/


  //zad8
    /*Average average= new Average();
    int [] arr1= new int[10];
    int sum=0;
    int sum2=0;
    for (int index=0; index<10; index++){
      arr1[index]=int.Parse(Console.ReadLine());
    }
    int [] arr2= new int[10];
    for (int index=0; index<10; index++){
      arr2[index]=int.Parse(Console.ReadLine());
    }
    for (int index=0; index<10; index++){
      sum+=arr1[index];
    }
    for (int index=0; index<10; index++){
      sum2+=arr2[index];
    }
    Console.WriteLine(average.checkAverage(arr1,arr2, sum, sum2));*/


  //zad9
    int n=int.Parse(Console.ReadLine());
    Series series = new Series();
    Console.WriteLine(series.series(n));

  }
}