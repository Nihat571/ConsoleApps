using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class Library
{
    public static Book[] books = new Book[0];
    Book[] newBooks = [];

    public void AddBook(Book book)
    {
        Array.Resize(ref books, books.Length + 1);
        books[^1] = book;
        Console.WriteLine("kitab elave edildi");
    }

    public Book GetById(int id)
    {
        foreach (var item in books)
        {
            if (item.Id == id)
            {
                return item;
            }
            else
            {
                Console.WriteLine($"{id}-li kitab tapilmadi");
            }
        }
        throw new Exception("Kitab yoxdur.");
    }



    public void RemoveBook(int id)
    {
        foreach (var item in books)
        {
            if (item.Id != id)
            {
                Array.Resize(ref newBooks, newBooks.Length + 1);
                newBooks[^1] = item;
                Console.WriteLine("kitab silindi");
            }
            else
            {
                Console.WriteLine("kitab tapilmadi");
            }
        }
        throw new Exception("kitAB yoxdur");
    }

    public Book GetBook(string name)
    {
        foreach (var item in books)
        {
            if (item.Name.ToLower() == name.ToLower())
            {
                return item;
            }
            else
            {
                Console.WriteLine("kitab tapilmadi");
            }
        }
        throw new Exception("kitab yoxdur");
    }

  
}
