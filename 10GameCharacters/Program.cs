namespace _10GameCharacters;

public class Character
{
  public string Name { get; set;}
  public int Health { get; set; }

  public Character(string name, int health)
  {
    Name = name;
    Health = health;
  }
  public void DisplayHealth()
  {
    System.Console.WriteLine($"{Name}'in sağlığı: {Health}");
  }
  public virtual void Attack()
  {
    System.Console.WriteLine($"{Name} saldırıyor!");
  }
}
public class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health) { }

    public void SwordAttack()
    {
        System.Console.WriteLine($"{Name}kılıçla saldırdı! ");
    }
    public override void Attack()
    {
        SwordAttack();
    }
}
public class Mage : Character
{
    public Mage(string name, int health) : base(name, health) { }
    public void CastSqell()
    {
        System.Console.WriteLine($"{Name} büyü yaptı! ");
    }
    public override void Attack()
    {
        CastSqell();
    }
}
public class Archer : Character 
{
    public Archer(string name, int health) : base(name, health) { }

    public void ShootArrow()
   {
    System.Console.WriteLine($"{Name} ok attı!");
   }
    public override void Attack()
    {
        ShootArrow();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior("Thor", 100);
        Mage mage = new Mage("Gandalf", 80);
        Archer archer = new Archer("Legolas", 90);

        warrior.DisplayHealth();
        mage.DisplayHealth();
        archer.DisplayHealth();
        System.Console.WriteLine();

        warrior.Attack();
        mage.Attack();
        archer.Attack();
    }
}