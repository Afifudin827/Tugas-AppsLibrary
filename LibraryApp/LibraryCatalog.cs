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

    public static bool removeBook(Book booksks)
    {
        try
        {
            var item = books.SingleOrDefault(x => x.title == booksks.title);
            if (item != null && item.title == booksks.title)
            {
                books.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            return false;
        }
    }
    public static Book findBook(string title, string status)
    {
        foreach (var item in books)
        {
            switch (status)
            {
                case "find":
                    if (item.title.Contains(title))
                    {
                        return new Book(item.title, item.author, item.publicationYear);
                    }
                    break;
                case "remove":
                    if (item.title == title)
                    {
                        return new Book(item.title, item.author, item.publicationYear);
                    }
                    break;
            }

        }
        return new Book();
    }
    public static List<Book> listBook()
    {
        return books;
    }
}
