using System.Security.Cryptography.X509Certificates;

namespace _05CalendarApplication;

public class Event 
{
    public string Name { get; set; }
    public DateTime Date { get; set; } 
    public string Location { get; set;}

    public Event (string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Etkinlik: {Name}, Traih: {Date.ToShortDateString()}, Yer: {Location}");
    }
}
public class Meeting : Event
{
    public string Agenda { get; set; }
    public Meeting (string name, DateTime date, string location, string agenda)
        :base(name, date, location)
        {
            Agenda = agenda;
        }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                System.Console.WriteLine($"Toplantı Gündemi: {Agenda}");
            }
        
}
public class Birthday : Event
{
    public string CelebrantName { get; set; }

    public Birthday(string name, DateTime date, string location, string celebrantName)
     :base(name, date, location)
     {
        CelebrantName = celebrantName;
     }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Kutlanan Kişi: {CelebrantName}");
    }

}

public class Task : Event
{ 
    public bool IsCompleted { get; private set; }
    public Task (string name, DateTime date, string location)
    :base(name, date, location)
    {
    IsCompleted = false;
    } 
    public void MarkAsComplete()
    {
        IsCompleted = true;
        System.Console.WriteLine($"Görev tamamlandı: {Name}");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Görev Tamamlandı mı: {(IsCompleted ? "Evet" :"Hayır")}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Meeting meeting = new Meeting("İş Toplantısı", new DateTime(2024, 10, 15), "Toplantı Odaı A", "Yıllık Planlama");
        Birthday birthday = new Birthday("Doğum Günü Partisi", new DateTime(2024, 11, 5), "Ev", "Ali");
        Task task = new Task("Proje Teslimi", new DateTime( 2024, 9, 30), "Ofis");

        meeting.DisplayInfo();
        System.Console.WriteLine();

        birthday.DisplayInfo();
        System.Console.WriteLine();
         
        task.DisplayInfo();
        task.MarkAsComplete();
        task.DisplayInfo();
    }
}
