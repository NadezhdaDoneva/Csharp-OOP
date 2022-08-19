using System;

/*class Animal
{
  public string species;
  public void move()
  {
    Console.WriteLine("Moving");
  }
}

class Dog: Animal
{
  public void bark()
  {
    Console.WriteLine("Bau bau");
  }
}*/

class Atom
{
  public string name;
  public int protoni;
  public int elektroni;
  public void print()
  {
    Console.WriteLine(this.name + " has " + Convert.ToString(this.protoni) + " protons and " + Convert.ToString(this.elektroni) + " electrons.");
  }
}


class Oxygen: Atom
{
  public Oxygen()
  {
    base.name= "Oxygen";
    base.protoni = 8;
    base.elektroni = 8;
  }
}


class Hydrogen: Atom
{
  public Hydrogen()
  {
     base.name= "Hydrogen";
    base.protoni = 1;
    base.elektroni = 1;
  }
}


class Titanium: Atom
{
  public Titanium()
  {
     base.name= "Titanium";
    base.protoni = 22;
    base.elektroni =22;
  }
}


class Scandium: Atom
{
  public Scandium()
  {
     base.name= "Scandium";
    base.protoni = 21;
    base.elektroni = 21;
  }
}


class Barium: Atom
{
  public Barium()
  {
     base.name= "Barium";
    base.protoni = 56;
    base.elektroni = 56;
  }
}


class Radium: Atom
{
  public Radium()
  {
     base.name= "Radium";
    base.protoni = 88;
    base.elektroni = 88;
  }
}


class Francium: Atom
{
  public Francium()
  {
     base.name= "Francium";
    base.protoni = 87;
    base.elektroni = 87;
  }
}


class Celsium: Atom
{
  public Celsium()
  {
     base.name= "Celsium";
    base.protoni = 55;
    base.elektroni = 55;
  }
}


class Calcium: Atom
{
  public Calcium()
  {
     base.name= "Calcium";
    base.protoni = 20;
    base.elektroni = 20;
  }
}


class Magnecium: Atom
{
  public Magnecium()
  {
     base.name= "Magnecium";
    base.protoni = 12;
    base.elektroni = 12;
  }
}




class Program {
  public static void Main (string[] args) {
  /*  Dog myDog = new Dog();
    myDog.species = "dog";
    Console.WriteLine(myDog.species);
    myDog.move();
    myDog.bark();*/


    Oxygen myOxygen = new Oxygen();
    myOxygen.print();

    Hydrogen myHydrogen = new Hydrogen();
    myHydrogen.print();

    Titanium myTitanium = new Titanium();
    myTitanium.print();

    Scandium myScandium = new Scandium();
    myScandium.print();

    Barium myBarium = new Barium();
    myBarium.print();

    Radium myRadium = new Radium();
    myRadium.print();

    Francium myFrancium = new Francium();
    myFrancium.print();

    Celsium myCelsium = new Celsium();
    myCelsium.print();

    Calcium myCalcium = new Calcium();
    myCalcium.print();

    Magnecium myMagnecium = new Magnecium();
    myMagnecium.print();
  }
}