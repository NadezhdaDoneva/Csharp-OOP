using System;
					
public class Student
{ // atributi
	public string name; // ime na uchenika
	public string clas; // klas
	public string id; // nomer v klasa
	// ocenki po osnovnite ptedmeti
	private double dBEL,dForeign,dMath,dPhys,dChem,dBio;
	// sreden uspeh
	private double average;
	// getari/setari
	public double DBEL
	{ set {this.dBEL = value; }get {return this.dBEL;}}
	public double DForeign
	{ set {this.dForeign = value; }get {return this.dForeign;}}
	public double DMath
	{ set {this.dMath = value; }get {return this.dMath;}}
	public double DPhys
	{ set {this.dPhys = value; }get {return this.dPhys;}}
	public double DChem
	{ set {this.dChem = value; }get {return this.dChem;}}
	public double DBio
	{ set {this.dBio = value; }get {return this.dBio;}}
	public double Average
	{ set { this.average = value; } get { return this.average; }}
}
public class Program {
  public static void Main (string[] args)
	{ Student std = new Student ();
	Console.Write("Vavedte ime:"); std.name = Console.ReadLine();
	Console.Write("Vavedte klas:"); std.clas = Console.ReadLine();
	Console.Write("Vavedte nomer:"); std.id = Console.ReadLine();
	Console.Write("Ocenka BEL:");
	std.DBEL = double.Parse(Console.ReadLine());
	Console.Write("Ocenka Chuzhd ezik:");  
	std.DForeign = double.Parse(Console.ReadLine());
	Console.Write("Ocenka Matematika:");
	std.DMath = double.Parse(Console.ReadLine());
	Console.Write("Ocenka Fizika:");
	std.DPhys = double.Parse(Console.ReadLine());
	Console.Write("Ocenka Biologiq:");
	std.DBio = double.Parse(Console.ReadLine());
	Console.Write("Ocenka Himiq:");
	std.DChem = double.Parse(Console.ReadLine());
	std.Average = (std.DBEL + std.DForeign + std.DMath + std.DPhys + std.DChem + std.DBio)/6;
	Console.WriteLine("SPRAVKA");
	Console.WriteLine("za uspeha na {0}, uchenik ot", std.name);
	Console.WriteLine("{0} klas, nomer {1]", std.clas, std.id);
	Console.WriteLine("BEL - {0,4:0.00}", std.DBEL);
	Console.WriteLine("Chuzhd ezik - {0,4:0.00}", std.DForeign);
	Console.WriteLine("Matematika - {0,4:0.00}", std.DMath);
	Console.WriteLine("Fizika - {0,4:0.00}", std.DPhys);
	Console.WriteLine("Himiq - {0,4:0.00}", std.DChem);
	Console.WriteLine("Biologiq - {0,4:0.00}", std.DBio);
	Console.WriteLine("Sreden uspeh - {0,4:0.00}", std.Average);
	}
}
