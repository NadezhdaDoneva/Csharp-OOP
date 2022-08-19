using System;
//zad1
/*class Rational {
  public double numerator;
  public double denominator;
}

//zad2
class Point{
  public double x;
  public double y;
}

//zad3
class Student {
  public string firstName;
  public string lastName;
  public int grade;
  public string gender;
}

//zad4
class Triangle{
  public double a;
  public double b;
  public double c;
}


//zad5
class Time{
  public int hour;
  public int minute;
  public int second;
  public int millisecond;
}


//zad6
class Date{
  public int dayOfMonth;
  public int month;
  public int dayOfWeek;
  public int year;
}


//zad7
class Reseat{
  public string date;
  public double amount;
  public double tax;  
}*/


//zad8
class Laptop{
public double ram;
public double cupClock;
public string cpuModel;
public string gpuModel;
}

//zad1
class Program {
  public static void Main (string[] args) {
    /*
    Rational drop1= new Rational();
    drop1.numerator= double.Parse(Console.ReadLine());
    drop1.denominator= double.Parse(Console.ReadLine());
    Rational drop2= new Rational();
    drop2.numerator= double.Parse(Console.ReadLine());
    drop2.denominator= double.Parse(Console.ReadLine());
    Console.WriteLine((drop1.numerator*drop2.denominator+ drop1.denominator*drop2.numerator)/(drop1.denominator*drop2.denominator));
    Console.WriteLine((drop1.numerator*drop2.denominator- drop1.denominator*drop2.numerator)/(drop1.denominator*drop2.denominator));*/


    //zad2
    /*Point myDot1 = new Point();
    myDot1.x= double.Parse(Console.ReadLine());
    myDot1.y= double.Parse(Console.ReadLine());

    Point myDot2 = new Point();
    myDot2.x= double.Parse(Console.ReadLine());
    myDot2.y= double.Parse(Console.ReadLine());

    Console.WriteLine(Math.Sqrt((myDot2.x-myDot1.x)*(myDot2.x-myDot1.x)+ (myDot2.y-myDot1.y)*(myDot2.y-myDot1.y)));*/

    //zad3
    /*Student a = new Student();
    a.firstName=Console.ReadLine();
    a.lastName=Console.ReadLine();
    a.grade=int.Parse(Console.ReadLine());
    a.gender=Console.ReadLine();

     Student b = new Student();
    b.firstName= Console.ReadLine();
    b.lastName=Console.ReadLine();
    b.grade=int.Parse(Console.ReadLine());
    b.gender=Console.ReadLine();

     Student c = new Student();
    c.firstName= Console.ReadLine();
    c.lastName=Console.ReadLine();
    c.grade=int.Parse(Console.ReadLine());
    c.gender=Console.ReadLine();

     Student d = new Student();
    d.firstName= Console.ReadLine();
    d.lastName=Console.ReadLine();
    d.grade=int.Parse(Console.ReadLine());
    d.gender=Console.ReadLine();

    Console.WriteLine(a.firstName);
    Console.WriteLine(a.lastName);
    Console.WriteLine(a.grade);
    Console.WriteLine(a.gender);
    Console.WriteLine(b.firstName);
    Console.WriteLine(b.lastName);
    Console.WriteLine(b.grade);
    Console.WriteLine(b.gender);
    Console.WriteLine(c.firstName);
    Console.WriteLine(c.lastName);
    Console.WriteLine(c.grade);
    Console.WriteLine(c.gender);
    Console.WriteLine(d.firstName);
    Console.WriteLine(d.lastName);
    Console.WriteLine(d.grade);
    Console.WriteLine(d.gender);*/


   //zad4
   /*double x =Convert.ToDouble(Console.ReadLine());
   double y =Convert.ToDouble(Console.ReadLine());
   double z =Convert.ToDouble(Console.ReadLine());
   
   if (x+y>z && x+z>y && y+z>x) {
     Triangle triugulnik = new Triangle();
     triugulnik.a = x;
     triugulnik.b = y;
     triugulnik.c = z;
     Console.WriteLine(triugulnik.a);
     Console.WriteLine(triugulnik.b);
     Console.WriteLine(triugulnik.c);
   }
   else {
   Console.WriteLine("this triangle does not exist");
   }*/


   //zad5
   /*int h = Convert.ToInt32(Console.ReadLine());
   int min = Convert.ToInt32(Console.ReadLine());
   int sec = Convert.ToInt32(Console.ReadLine());
   int msec = Convert.ToInt32(Console.ReadLine());
   if (h<=23 || h>=0 || min<=59 || min>=0 || sec<=60 || sec>=0 || msec<=999 || msec>=0){
     Time vr = new Time();
     vr.hour = h;
     vr.minute = min;
     vr.second = sec;
     vr.millisecond = msec;
     Console.WriteLine(vr.hour+":"+vr.minute+":"+vr.second+":"+vr.millisecond);
   }
   else
   Console.WriteLine("this time does not exist");*/


   //zad6
   /*int denmesec=Convert.ToInt32(Console.ReadLine());
   int mesec = Convert.ToInt32(Console.ReadLine());
   int densedm = Convert.ToInt32(Console.ReadLine());
   int godina = Convert.ToInt32(Console.ReadLine());
   if (godina<0 || densedm<1 || densedm>7 || mesec<1 || mesec>12 || denmesec<1 || denmesec>31){
     Console.WriteLine("this date does not  exist");
   }
   else if (denmesec>28 + (mesec +(mesec/8))%2+2%mesec+2*(1/mesec)){
     Console.WriteLine("this month does not have that many days");
   }
     else {
       Date data=new Date();
       data.dayOfMonth=denmesec;
       data.month=mesec;
       data.dayOfWeek=densedm;
       data.year=godina;
       Console.WriteLine(data.dayOfMonth);
       Console.WriteLine(data.month);
       Console.WriteLine(data.dayOfWeek);
       Console.WriteLine(data.year);
     }*/



     /*string data =Console.ReadLine();
     double amo = Convert.ToDouble(Console.ReadLine());
     double taxa = Convert.ToDouble(Console.ReadLine());
     if (amo<0 || taxa<0){
       Console.WriteLine("false input");
     }
     else {
       Reseat factura = new Reseat();
       factura.date = data;
       factura.amount = amo;
       factura.tax = taxa;
       Console.WriteLine("data:"+factura.date);
       Console.WriteLine("amount:"+factura.amount);
       Console.WriteLine("tax:"+factura.tax);
     }*/


     //zad8
     double gb1 = Convert.ToDouble(Console.ReadLine());
     double chestota1 = Convert.ToDouble(Console.ReadLine());
     string  cmodel1 = Console.ReadLine();
     string gmodel1 = Console.ReadLine();
     double gb2 = Convert.ToDouble(Console.ReadLine());
     double chestota2 = Convert.ToDouble(Console.ReadLine());
     string  cmodel2 = Console.ReadLine();
     string gmodel2 = Console.ReadLine();
     if (gb1<0 || gb2<0 || chestota1<0 || chestota2<0){
       Console.WriteLine("incorrrect input");
     }
     else if(gb1>gb2){
       Console.WriteLine("the first one is better");
     }
     else if (gb1<gb2){
       Console.WriteLine("the seond one is better");
     }
     else {
       if (chestota1>chestota2){
         Console.WriteLine("the first one is better");
       }
       else if (chestota2>chestota1){
         Console.WriteLine("the first one is better");
     }
     else {
       Console.WriteLine("they are both equally good");
     }
     }
  }
}
