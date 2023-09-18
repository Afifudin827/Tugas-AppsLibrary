using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp;
class Book
{
    protected static List<Book> books = new List<Book>();
    public string title { get; set; }
    public string author {  get; set; }
    public string publicationYear {  get; set; }

    public Book() { }
    public  Book(string title, string author, string publicationYear) 
    {
        this.title = title;
        this.author = author;
        this.publicationYear = publicationYear;
    }
}
