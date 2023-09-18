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

    public static bool removeBook(Book booksk)
    {
        try
        {
            books.RemoveAll(x => x.title == booksk.title);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    public static Book findBook(string title)
    {
        List<Book> list = new List<Book>();
        foreach (var item in books)
        {
            if (item.title.Contains(title))
            {
                return new Book(item.title, item.author, item.publicationYear);
            }
        }
        return new Book();
    }
    public static List<Book> listBook()
    {
        return books;   
    }
}
