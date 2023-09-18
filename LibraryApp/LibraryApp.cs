namespace LibraryApp;

class LibraryApp
{
    public static void Main(string[] args)
    {
        bool program = true;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Library App ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");

            //Membuat selectin pilihan menu
            Console.Write("Select : ");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    Console.Clear();
                    AddBooksMenu();
                    break;
                case "2":
                    Console.Clear();
                    RemoveBookMenu();
                    break;
                case "3":
                    Console.Clear();
                    ListBookMenu();
                    searchBook();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Sorry your selection program is invalid!!!");
                    Console.ReadKey();
                    break;

            }
        } while (program);

    }

    private static void AddBooksMenu()
    {
        Book libraryBooks = new Book();
        Console.Clear();
        Console.WriteLine("=== Add Books ===");
        Console.Write("Book Title       : ");
        string title = Console.ReadLine();
        Console.Write("Author           : ");
        string author = Console.ReadLine();
        Console.Write("Publication Year : ");
        string pubYear = Console.ReadLine();
        libraryBooks.title = title;
        libraryBooks.author = author;
        libraryBooks.publicationYear = pubYear;
        if (LibraryCatalog.addBook(libraryBooks))
        {
            Console.Write("=== Add Books Success ===");
        }
        else
        {
            Console.Write("=== Add Book Failed ===");
        }
        Console.ReadKey();
    }

    private static void ListBookMenu()
    {
        Console.WriteLine("=== List of Books ===");
        foreach (var data in LibraryCatalog.listBook())
        {
            Console.WriteLine($"Book title          : {data.title}");
            Console.WriteLine($"Author              : {data.author}");
            Console.WriteLine($"Publication Year    : {data.publicationYear}");
            Console.WriteLine("========================");
        }
    }

    private static void RemoveBookMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Menu remove book from catalog ===");
        ListBookMenu();
        Console.Write("Search Title to remove : ");
        string title = Console.ReadLine();
        if (LibraryCatalog.removeBook(LibraryCatalog.findBook(title)))
        {
            Console.WriteLine("Books Was Success to remove");
        }
        else
        {
            Console.WriteLine("Books was Failed to remove");
        }
        Console.ReadKey();
    }

    private static void searchBook()
    {
        Console.Write("Search title : ");
        string title = Console.ReadLine();
        Console.WriteLine("Books Title      : " +LibraryCatalog.findBook(title).title);
        Console.WriteLine("Author           : " + LibraryCatalog.findBook(title).author);
        Console.WriteLine("Year Publication : " + LibraryCatalog.findBook(title).publicationYear);
    }
}