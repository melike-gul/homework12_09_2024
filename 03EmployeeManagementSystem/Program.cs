namespace _03EmployeeManagementSystem;

public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"İsim: {Name}, Kimlik Numarası: {Id}, Maaş: {Salary} TL");
    }
}
public class Manager : Employee
{
    public int NumberOfTeams{ get; set; }
    public Manager(string name, int id,decimal salary, int numberOfTeams)
    :base(name, id, salary)
    {
        NumberOfTeams = numberOfTeams;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Yönetilen Takım Sayısı: {NumberOfTeams}");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, int id, decimal salary, string programmingLanguage)
        :base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Programlama Dili: {ProgrammingLanguage}");
    }
}

public class Intern : Employee
{
    public Intern(string name, int id, decimal salary)
    :base (name, id, salary)
    {
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine("Stajyer");
    }
}
class Program 
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Ahmet Yılmaz", 1001, 15000, 3);
        Developer developer = new Developer ("Elif Kara", 1002, 1200, "C#");
        Intern intern = new Intern ("Deniz Aslan", 1003, 5000);
        
        manager.DisplayInfo();
        System.Console.WriteLine();

        developer.DisplayInfo();
        System.Console.WriteLine();
        
        intern.DisplayInfo();

    }
}
