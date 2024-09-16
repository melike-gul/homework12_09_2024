using System;
using System.Collections.Generic;


namespace _04LibraryApplication;

public class Book
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public string ISBN { get; set; }
    public bool IsBorrowed { get; private set; }

    
    public Book(string title, string author, int pages, string isbn)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = isbn;
        IsBorrowed = false;
    }

   
    public void Borrow()
    {
        if (!IsBorrowed)
        {
            IsBorrowed = true;
            Console.WriteLine($"Kitap ödünç alındı: {Title}");
        }
        else
        {
            Console.WriteLine($"Kitap zaten ödünç alınmış: {Title}");
        }
    }

    
    public void Return()
    {
        if (IsBorrowed)
        {
            IsBorrowed = false;
            Console.WriteLine($"Kitap iade edildi: {Title}");
        }
        else
        {
            Console.WriteLine($"Kitap zaten kütüphanede: {Title}");
        }
    }

    // Kitap bilgilerini gösteren metod
    public void DisplayInfo()
    {
        Console.WriteLine($"Başlık: {Title}, Yazar: {Author}, Sayfa Sayısı: {Pages}, ISBN: {ISBN}, Ödünç Alındı mı: {(IsBorrowed ? "Evet" : "Hayır")}");
    }
}

public class Library
{
    private List<Book> books;


    public Library()
    {
        books = new List<Book>();
    }

    
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Kitap kütüphaneye eklendi: {book.Title}");
    }

    
    public void ListBooks()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }

    
    public void BorrowBook(string isbn)
    {
        Book book = books.Find(b => b.ISBN == isbn);
        if (book != null)
        {
            book.Borrow();
        }
        else
        {
            Console.WriteLine("Bu ISBN numarasıyla eşleşen kitap bulunamadı.");
        }
    }

    
    public void ReturnBook(string isbn)
    {
        Book book = books.Find(b => b.ISBN == isbn);
        if (book != null)
        {
            book.Return();
        }
        else
        {
            Console.WriteLine("Bu ISBN numarasıyla eşleşen kitap bulunamadı.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Library library = new Library();

        
        Book book1 = new Book("1984", "George Orwell", 328, "9780451524935");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 281, "9780061120084");

        library.AddBook(book1);
        library.AddBook(book2);

        library.ListBooks();
        Console.WriteLine();

        
        library.BorrowBook("9780451524935");
        library.BorrowBook("9780451524935"); 
        Console.WriteLine();

        library.ReturnBook("9780451524935");
        library.ReturnBook("9780451524935"); 
        Console.WriteLine();

        library.ListBooks();
    }
}
