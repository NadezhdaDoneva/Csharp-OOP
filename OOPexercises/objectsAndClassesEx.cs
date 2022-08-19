//zad1
class Location{

  private int _east;
  private int _west;
  private int _south;
  private int _north;
  


  public Loc(int e, int w, int s, int n){
    if (e>-180 && e<180){
      this._east=e;
    }
    if (w>-180 && w<180){
      this._west=w;
    }
    if (s>0 && s<90){
      this._south=s;
    }
    if (n>0 && n<90){
      this._north=n;
    }
  }

  public void print(){
    Console.WriteLine(this._east);
    Console.WriteLine(this._west);
    Console.WriteLine(this._south);
    Console.WriteLine(this._north);
  }


  public int East{
    get {
      return this._east;
    }
    set{
      if (value>-180 && value<180){
        this._east=value;
      }
      else {
        this._east=0;
      }
    }
  }

  public int West{
    get {
      return this._west;
    }
    set{
      if (value>-180 && value<180){
        this._west=value;
      }
      else {
        this._west=0;
      }
    }
  }

  public int South{
    get {
      return this._south;
    }
    set{
      if (value>0 && value<90){
        this._south=value;
      }
      else {
        this._south=0;
      }
    }
  }

  public int North{
    get {
      return this._north;
    }
    set{
      if (value>0 && value<90){
        this._north=value;
      }
      else {
        this._north=0;
      }
    }
  }
}

//zad2
/*class Farm{
  private int _numberOfAnimals;
  private int _numberOfWorkers;
  public int NumberOfAnimals{
    get{
      return this._numberOfAnimals;
    }
    set {
      if (value>0){
        this._numberOfAnimals=value;
      }
      else {
        this._numberOfAnimals=0;
      }
    }
  }
  public int NumberOfWorkers{
    get{
      return this._numberOfWorkers;
    }
    set {
      if (value>0){
        this._numberOfWorkers=value;
      }
      else {
        this._numberOfWorkers=0;
      }
    }
  }
}*/

//zad3
/*class Flower{
  public string Color{
    get; set;
  }
  public string Species{
    get; set;
  }
  public string Season{
    get; set;
  }
}*/

//zad4
/*class Vehicle{
  public string Type{
    get; set;
  }
  public string Medium{
    get; set;
  }
}*/

//zad5
/*class Home{
  public string Type{
    get; set;
  }
  private int _numberOfRooms;
  public bool HasYard{
    get; set;
  }
  private double _price;

   public int NumberOfRooms{
    get{
      return this._numberOfRooms;
    }
    set{
      if (value>0){
        this._numberOfRooms=value;
    }
    else{
      this._numberOfRooms=0;
    }
  }
 }

   public double Price {
    get{
      return this._price;
   }
    set{
      if (value>0){
        this._price=value;
    }
    else{
      this._price=0;
    }
  }
}
}*/

//zad6
/*class Food{
  public string Name{
    get; set;
  }
  public string Type{
    get;set;
  }
  private double _price;
  public double Price{
    get{
      return this._price;
    }
    set{
      if (value>0){
        this._price=value;
    }
    else{
      this._price=0;
    }
  }
}
}*/

//zad7
/*class PlayCard{
  private int _rank;
  public string Suit;
  public int Rank{
    get{
      return this._rank;
    }
    set{
      if (value>0 && value<=10){
        this._rank=value;
      }
      else{
        this._rank=0;
      }
    }
  }
  public void print() {
    Console.WriteLine("kartata e: " + _rank + " " + Suit);
  }
}*/

//zad8
/*class Book{
  public string Title{
    get; set;
  }
  public string Author{
    get; set;
  }
  private double _price;
  private int _count;
  public double Price{
    get{
      return this._price;
    }
    set{
      if (value>0){
        this._price=value;
      }
      else{
        this._price=0;
      }
    }
  }
  public int Count{
    get{
      return this._count;
    }
    set{
      if (value>0){
        this._count=value;
      }
      else{
        this._count=0;
      }
    }
  }
}*/

class Program {
  public static void Main (string[] args) {

    //zad1
    Location location = new Location();
    location.East = int.Parse(Console.ReadLine());
    location.West = int.Parse(Console.ReadLine());
    location.South = int.Parse(Console.ReadLine());
    location.North = int.Parse(Console.ReadLine());
    Console.WriteLine("east: " + location.East);
    Console.WriteLine("west: " + location.West);
    Console.WriteLine("south: " + location.South);
    Console.WriteLine("north: " + location.North);


    //zad2
    /*Farm farm = new Farm();
    farm.NumberOfAnimals = int.Parse(Console.ReadLine());
    farm.NumberOfWorkers = int.Parse(Console.ReadLine());
    Console.WriteLine("animals: " + farm.NumberOfAnimals);
    Console.WriteLine("workers: " + farm.NumberOfWorkers);*/

    //zad3
    /*Flower flower = new Flower();
    flower.Color =  Console.ReadLine();
    flower.Species =  Console.ReadLine();
    flower.Season = Console.ReadLine();
    Console.WriteLine("color: " + flower.Color);
    Console.WriteLine("species: " + flower.Species);
    Console.WriteLine("season: " + flower.Season);*/

    //zad4
    /*Vehicle vehicle = new Vehicle();
    vehicle.Type = Console.ReadLine();
    vehicle.Medium = Console.ReadLine();
    Console.WriteLine("type: " + vehicle.Type);
    Console.WriteLine("medium: " + vehicle.Medium);*/

    //zad5
   /* Home home = new Home();
    home.Type = Console.ReadLine();
    home.NumberOfRooms= int.Parse(Console.ReadLine());
    home.HasYard =Convert.ToBoolean(Console.ReadLine());
    home.Price = double.Parse(Console.ReadLine());
    Console.WriteLine("type: " + home.Type);
    Console.WriteLine("number of rooms: " + home.NumberOfRooms);
    Console.WriteLine("yard: " + home.HasYard);
    Console.WriteLine("price: " + home.Price);*/

    //zad6
    /*Food food = new Food();
    food.Name = Console.ReadLine();
    food.Type = Console.ReadLine();
    food.Price = double.Parse(Console.ReadLine());
    Console.WriteLine("name: " + food.Name);
    Console.WriteLine("type: " + food.Type);
    Console.WriteLine("price: " + food.Price);*/

    //zad7
    /*PlayCard card = new PlayCard();  
    card.Rank = int.Parse(Console.ReadLine());
    card.Suit = Console.ReadLine();
    card.print();*/
 
    //zad8
    /*Book book = new Book();
    book.Title = Console.ReadLine();
    book.Author = Console.ReadLine();
    book.Price = double.Parse(Console.ReadLine());
    book.Count = int.Parse(Console.ReadLine());
    Console.WriteLine("title: " + book.Title);
    Console.WriteLine("author: " + book.Author);
    Console.WriteLine("price: " + book.Price);
    Console.WriteLine("count: " + book.Count);*/
  }
}