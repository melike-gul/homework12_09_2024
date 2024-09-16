using System.Diagnostics.Contracts;

namespace _08EducationalInstitutionApplication;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void AttendClass()
    {
        System.Console.WriteLine($"{Name} derse katıldı.");
    }
}

public class Teacher : Person
{
    public string SubjectTaught { get; set;}

    public Teacher(string name, int age, string SubjectTaught)
      : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }
    public override void AttendClass()
    {
      System.Console.WriteLine($"Öğretmen {Name}, {SubjectTaught} dersine katıldı. ");
    }
}
public class Student : Person
{
    public int GradeLevel { get; set; }
    public Student(string name,int age, int gardeLevel)
       : base(name, age)
     {
        GradeLevel = gardeLevel;
     }

    public override void AttendClass()
    {
        System.Console.WriteLine($"Öğrenci{Name}, {GradeLevel}. sınıf dersine katıldı.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Ayşe", 40, "Matematik");
        Student student = new Student ("Ali", 16, 10);

        teacher.AttendClass();
        student.AttendClass();
    }
}

