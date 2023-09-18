namespace LibraryApp;
class ErrorHandler
{
    public static bool errorInputValidate(string title, string status)
    {
        switch (status)
        {
            case "title":
                if (string.IsNullOrEmpty(title) || LibraryCatalog.findBook(title, "find").title == title)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                break;
            default:
                if (string.IsNullOrEmpty(title))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                break;
        }

    }

    public static void errorRemoveBook(string title)
    {
        if (!ErrorHandler.errorInputValidate(title, ""))
        {
            Console.WriteLine("Input title invalid");
        }
        else if (LibraryCatalog.removeBook(LibraryCatalog.findBook(title, "remove")))
        {
            Console.WriteLine("Books Was Success to remove");
        }
        else
        {
            Console.WriteLine("title Books is invalid");
        }
    }
    public static bool errorSearchBook(string title)
    {
        if (string.IsNullOrEmpty(LibraryCatalog.findBook(title, "find").title) || title == "")
        {
            Console.WriteLine("Sorry book not available");
            return false;
        }
        return true;
    }
}
