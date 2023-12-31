﻿namespace LibraryApp;

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
                    program = false;
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
        string title, author, pubYear;
        bool programs = true;
        do
        {
            Console.Write("Book Title       : ");
            title = Console.ReadLine();
            if (!ErrorHandler.errorInputValidate(title, "title"))
            {
                programs = true;
                Console.WriteLine("Sorry title have been available or wrong please enter again or else");
            }
            else
            {
                programs = false;
            }
        } while (programs);
        do
        {
            Console.Write("Author           : ");
            author = Console.ReadLine();
            if (!ErrorHandler.errorInputValidate(author, ""))
            {
                programs = true;
                Console.WriteLine("Sorry your input invalid, please input correctly");
            }
            else
            {
                programs = false;
            }
        } while (programs);
        do
        {
            Console.Write("Publication Year : ");
            pubYear = Console.ReadLine();
            if (!ErrorHandler.errorInputValidate(pubYear, ""))
            {
                programs = true;
                Console.WriteLine("Sorry your input invalid, please input correctly");
            }
            else
            {
                programs = false;
            }
        } while (programs);
        libraryBooks.title = title;
        libraryBooks.author = author;
        libraryBooks.publicationYear = pubYear;
        LibraryCatalog.addBook(libraryBooks);
        Console.ReadKey();
    }

    private static void ListBookMenu()
    {
        Console.WriteLine("=== List of Books ===");
        foreach (var data in LibraryCatalog.listBook())
        {
            viewBooks(
                data.title,
                data.author,
                data.publicationYear);
            Console.WriteLine("========================");
        }
    }

    private static void RemoveBookMenu()
    {
        bool program = true;
        do
        {
            Console.Clear();
            Console.WriteLine("=== Menu remove book from catalog ===");
            ListBookMenu();
            Console.WriteLine("1. Remove book");
            Console.WriteLine("2. Back");
            Console.Write("Please enter selection : ");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    removeBook();
                    break;
                case "2":
                    program = false;
                    break;
                default:
                    Console.WriteLine("Your input was invalid, please type again");
                    Console.ReadKey();
                    break;
            }
        } while (program);
    }

    private static void searchBook()
    {
        Console.Write("Search title : ");
        string title = Console.ReadLine();
        if (ErrorHandler.errorSearchBook(title))
        {
            viewBooks(
                LibraryCatalog.findBook(title, "find").title,
                LibraryCatalog.findBook(title, "find").author,
                LibraryCatalog.findBook(title, "find").publicationYear);
        }
    }

    private static void removeBook()
    {
        Console.Write("Search Title to remove : ");
        string title = Console.ReadLine();
        ErrorHandler.errorRemoveBook(title);
        Console.ReadKey();
    }

    private static void viewBooks(string title, string author, string pubYear)
    {
        Console.WriteLine("Books Title      : " + title);
        Console.WriteLine("Author           : " + author);
        Console.WriteLine("Year Publication : " + pubYear);
    }
}