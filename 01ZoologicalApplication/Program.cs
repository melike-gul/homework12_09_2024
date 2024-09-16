using System.Data.SqlTypes;

namespace _01ZoologicalApplication;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public Animal (string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public virtual void MakeSound()
    {
        System.Console.WriteLine("Hayvan bir ses çıkarıyor.");
    }
}
public class Lion : Animal
{
    public Lion(string name, int age) : base (name, age, "Lion") { }

    public override void MakeSound()
    {
        System.Console.WriteLine("Aslan kükredi: Roar");
    }
}
public class Elephant : Animal
{
    public  Elephant(string name, int age) : base (name, age, " Elephant ") { }

    public override void MakeSound()
    {
        System.Console.WriteLine("Fil boru sesi çıkardır: Trumpet!");
    }
}
public class Giraffe : Animal 
{
    public Giraffe(string name, int age) : base(name, age, "Giraffe") { }

    public override void MakeSound()
    {
        System.Console.WriteLine("Zürafa düşük frenkansta ses çıkardı: Hum!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("Simba", 5);
        Elephant elephant = new Elephant("Dumbo", 10);
        Giraffe giraffe = new Giraffe("Melman", 7);

        lion.MakeSound();
        elephant.MakeSound();
        giraffe.MakeSound();
    }
}
