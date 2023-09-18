using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp;
class LibraryCatalog : Book
{
    public static bool addBook(Book book)
    {
        try
        {
            books.Add(book);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public static bool removeBook(Book book) 
    {
        try
        {   
            books.Remove(book);
            return true; 
        }catch (Exception e) 
        {
            return false;
        }
    }
    public static List<Book> findBook(string title) 
    {
        List<Book> list = new List<Book>();
        foreach (var item in books)
        {
            if (item.title.Contains(title))
            {
                list.Add( new Book(item.title, item.author, item.publicationYear));
                return list;
            }
        }
        return list;
    }
    public static void listBook()
    {
        foreach (var item in books)
        {
            
        }
    }
}
