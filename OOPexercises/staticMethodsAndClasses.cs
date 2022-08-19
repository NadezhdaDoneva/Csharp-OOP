using System;

static class Circle{
  public static float pi = 3.14159265358F;
  public static float circleArea(float radius){
    return pi*radius*radius;
  }
  public static float circlePerimeter(float radius){
    return 2*pi*radius;
  }
}


static class Ellipse{
  public static float pi = 3.14159265358F;
  public static double ellipseArea(double a, double b){
    return pi*a*b;
  }
  public static double ellipsePerimeter(double a, double b){
    return 2*pi*Math.Sqrt((a*a+b*b)/2);
  }
}


static class Square{
  public static double squareArea(double c){
    return c*c;
  }
  public static double squarePerimeter(double c){
    return 4*c;
  }
}


static class Triangle{
  public static double triangleArea(double d, double h){
    return d*h/2;
  }
  public static double trianglePerimeter(double d){
    return 3*d;
  }
}


static class Regtangle{
  public static double regtangleArea(double t, double p){
    return t*p;
  }
  public static double regtanglePerimeter(double t, double p){
    return 2*(t+p);
  }
}

static class Pentagon{
  public static double pentagonArea(double q){
    return Math.Sqrt(25+10*Math.Sqrt(5))*q*q/4;
  }
  public static double pentagonPerimeter(double q){
    return 5*q;
  }
}


static class Trapezoid{
  public static double trapezoidArea(double a, double b, double h){
    return (a+b)*h/2;
  }
  public static double trapezoidPerimeter(double a, double b, double c, double d){
    return a+b+c+d;
  }
}


static class Rhombus{
  public static double rhombusArea(double a, double h){
    return a*h;
  }
  public static double rhombusPerimeter(double a){
    return 4*a;
  }
}

class Program {
  public static void Main (string[] args) {
    //krug
    float r;
    r=float.Parse(Console.ReadLine());
    Console.WriteLine(Circle.circleArea(r));
    Console.WriteLine(Circle.circlePerimeter(r));

    //ellipse
    double a;
    double b;
    a=double.Parse(Console.ReadLine());
    b=double.Parse(Console.ReadLine());
    Console.WriteLine(Ellipse.ellipseArea(a,b));
    Console.WriteLine(Ellipse.ellipsePerimeter(a,b));


    //kwadrat
    double c;
    c=double.Parse(Console.ReadLine());
    Console.WriteLine(Square.squareArea(c));
    Console.WriteLine(Square.squarePerimeter(c));

    //triugalnik
    double d;
    d=double.Parse(Console.ReadLine());
    double h;
    h=double.Parse(Console.ReadLine());
    Console.WriteLine(Triangle.triangleArea(d,h));
    Console.WriteLine(Triangle.trianglePerimeter(d));

    //pravougulnik
    double t; 
    double p;
    t=double.Parse(Console.ReadLine());
    p=double.Parse(Console.ReadLine());
    Console.WriteLine(Regtangle.regtangleArea(t,p));
    Console.WriteLine(Regtangle.regtanglePerimeter(t,p));


    //petougulnik
    double q;
    q=double.Parse(Console.ReadLine());
    Console.WriteLine(Pentagon.pentagonArea(q));
    Console.WriteLine(Pentagon.pentagonPerimeter(q));


    //trapezoid
    double x;
    double y;
    double l;
    double o;
    double s;
    x=double.Parse(Console.ReadLine());
    y=double.Parse(Console.ReadLine());
    l=double.Parse(Console.ReadLine());
    o=double.Parse(Console.ReadLine());
    s=double.Parse(Console.ReadLine());
    Console.WriteLine(Trapezoid.trapezoidArea(x,y,l));
    Console.WriteLine(Trapezoid.trapezoidPerimeter(x,y,o,s));

    //romb
    double w;
    double k;
    w=double.Parse(Console.ReadLine());
    k=double.Parse(Console.ReadLine());
    Console.WriteLine(Rhombus.rhombusArea(w,k));
    Console.WriteLine(Rhombus.rhombusPerimeter(w));
  }
}