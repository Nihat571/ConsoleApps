using System.Globalization;
using System.Numerics;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book
            {
                Id = 1,
                Name = "7 Gozel",
                Price = 41,
            };

         
            string userNumber1 = Console.ReadLine();
            do
            {
            start:

                Console.WriteLine("1. Add book\r\n" +
                    "2. Get book by id\r\n" +
                    "3. Remove book\r\n" +
                    "4. Update Book\r\n" +
                    "5. Get all books\r\n" +
                    "6.Clear Console" + 
                    "0. Quit");

                Console.WriteLine("Seciminizi edin:");

                string userNumber = Console.ReadLine();
                int number;
                if (!int.TryParse(userNumber, out number))
                {
                    goto start;
                }
                switch (userNumber)
                {
                    case "0":
                        Console.Clear();
                        break;
                    case "1":
                        Console.WriteLine("Kitabin adini daxil edin:");
                        string newNookName = Console.ReadLine();

                        Console.WriteLine("Kitabin qiymetini daxil edin:");
                        double newBookPrice = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kitabin muellifini daxil edin:");
                        string newNookAuthor = Console.ReadLine();


                        try
                        {
                            Book newBook = new Book {
                            Name = newNookName,
                            Price = newBookPrice,
                            AuthorName = newNookAuthor,
                            Id =1
                            };
                            library.AddBook(newBook);
                            Console.WriteLine("added new Patient");
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "2":

                        Console.WriteLine("Kitabin nomresini daxil edin:");
                        int clickedId = int.Parse(Console.ReadLine());
                        try
                        {
                            
                            library.GetById(clickedId);
                      
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            goto start;
                        }
                        break;
                    case "3":
                        Console.WriteLine("silmek istediyiniz kitabin adini daxil edin:");
                        int clickedBook = int.Parse(Console.ReadLine());
                        library.RemoveBook(clickedBook);
                        break;
                    case "4":
                        Console.WriteLine("Hazir deyil");
                        break;
                        break;
                    case "5":
                        foreach (var item in Library.books)
                        {
                            Console.WriteLine($"{item.Id}. {item.Name}");
                            Console.WriteLine("-----------------------");
                        }
                        break;
                    case "6":
                        Console.Clear();
                        break;
                
                 
                    default:
                        break;
                }
            }

            while (true);
        }
    }
}
