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
}
