namespace _09BankingApplication;

public class Account
{
    public string AccountNumber {get; set;}
    public double Balance { get; set; }
    public Account (string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
            System.Console.WriteLine($"Hesaba {amount} TL yatırıldı. Yeni bakiye: {Balance} TL.");
        }
        else
        {
            System.Console.WriteLine("Geçersiz para yatırma işlemi.");
        }
    }
    public virtual void Withdraw(double amount)
    {
        if(amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            System.Console.WriteLine($"{amount} TL çekildi. Kalan Bakiye:{Balance} TL.");
        }else 
        {
            System.Console.WriteLine($"Hesap Numarası: {AccountNumber}, Bakiye: {Balance} TL.");
        }
    }
    public void DisplayBalance()
    {
        System.Console.WriteLine($"Hesap Numarası: {AccountNumber}, Bakiye: {Balance} TL.");
    }
}
public class SavingAccount : Account
{
    public double InteresrRate { get; set; }
    public SavingAccount(string accountNumber, double initialBalance, double interestRate)
      : base(accountNumber, initialBalance)
      {
        interestRate = interestRate;
      }
      public void ApplyInterest()
      {
        double interest = Balance * InteresrRate;
        Balance += interest;
        System.Console.WriteLine($"{interest} TL faiz uygulandı. Yeni bakiye: {Balance} TL.");
      }
}

public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, double initialBalance)
    : base(accountNumber, initialBalance)
    {
    }
    public void WriteCheck(double amount)
    {
        if (Balance >= amount)
        {
            Withdraw(amount);
            System.Console.WriteLine($"Çek yazıldı: {amount} TL. Kalan bakiye: {Balance} TL.");
        }
        else
        {
            System.Console.WriteLine("Yetersiz bakiye, çek yazılamaz.");
        }
    }
}
class Program 
{
    static void Main(string[] args)
    {
        SavingAccount saving = new SavingAccount("TR123456", 1000, 0.05);
        saving.DisplayBalance();
        saving.Deposit(500);
        saving.ApplyInterest();
        System.Console.WriteLine();

        CheckingAccount checking = new CheckingAccount("TR654321", 1500);
        checking.DisplayBalance();
        checking.Deposit(300);
        checking.WriteCheck(1000);
        checking.DisplayBalance();
    }
}