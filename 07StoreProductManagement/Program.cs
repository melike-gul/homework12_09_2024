namespace _07StoreProductManagement;

public class Product
{
   public string Name { get; set; }
   public double Price { get; set; }

   public int StockQuantity { get; set; }

   public Product(string name, double price, int stockQuantity)
   {
    Name = name;
    Price = price;
    StockQuantity = stockQuantity;
   }

   public void CheckStock()
   {
    System.Console.WriteLine($"{Name} üründen stokta {StockQuantity} adet var.");
   }
    public void UpdateStock(int amount)
    {
        StockQuantity += amount;
        System.Console.WriteLine($"{Name} ürünün stoğu {amount} kadar güncellendi . Yeni Stok: {StockQuantity}");
    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Ürün: {Name}, Fiyat: {Price} TL, Stok Miktarı: {StockQuantity}");
    }
}
public class FoodProduct : Product
{
    public DateTime ExpirationDate { get; set; }
    public FoodProduct(string name, double price, int stockQuantity, DateTime expirationDate)
       :base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Son Kullanma Tarihi : { ExpirationDate.ToShortDateString()}");
    }
}
public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; set; }
    public ElectronicProduct(string name, double price, int stockQuantity, int warrantyPeriod)
        :base(name, price, stockQuantity)
    {
        WarrantyPeriod = warrantyPeriod;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Garanti Süresi: {WarrantyPeriod} yıl");
    }
}

class Program
{
    static void Main(string[] args)
    {

        FoodProduct apple = new FoodProduct("Elma", 5.5, 100, new DateTime(2024, 10, 10));

        ElectronicProduct phone = new ElectronicProduct("Akıllı Telefon", 7000, 50, 2);

        apple.DisplayInfo();
        apple.CheckStock();
        apple.UpdateStock(-10);
        apple.CheckStock();
        System.Console.WriteLine();

        phone.DisplayInfo();
        phone.CheckStock();
        phone.UpdateStock(20);
        phone.CheckStock();

    }
}